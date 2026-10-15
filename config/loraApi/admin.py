from django.contrib import admin
from django.contrib import messages
from django.contrib.admin.actions import delete_selected
from django.core.exceptions import PermissionDenied
from django.db.models import Q

from .models import StockTransfer


@admin.register(StockTransfer)
class StockTransferAdmin(admin.ModelAdmin):
	list_display = (
		'transfer_id', 'branch', 'product_id', 'product_name', 'quantity',
		'target_quantity', 'status', 'retry_count', 'retry_after', 'created_at',
		'claimed_at', 'completed_at',
	)
	list_filter = ('branch', 'status')
	search_fields = ('transfer_id', 'product_name', 'product_id')
	actions = (
		'delete_pending_mini_market_transfers',
		'delete_pending_yeukai_transfers',
		'delete_pending_yeukai_stocktakes',
		'delete_failed_yeukai_commands',
	)

	def has_add_permission(self, request):
		return False

	def has_change_permission(self, request, obj=None):
		return False

	@admin.action(
		description='Delete selected pending Mini Market transfers',
		permissions=['delete'],
	)
	def delete_pending_mini_market_transfers(self, request, queryset):
		if not request.user.is_superuser:
			self.message_user(request, 'Only a superuser can remove transfer records.', messages.ERROR)
			return None

		eligible = queryset.filter(branch__iexact='Mini Market', status='pending')
		if not eligible.exists():
			self.message_user(request, 'No pending Mini Market transfers were selected.', messages.WARNING)
			return None

		return delete_selected(self, request, eligible)

	@admin.action(
		description='Delete selected pending YEUKAI transfers (not stocktakes)',
		permissions=['delete'],
	)
	def delete_pending_yeukai_transfers(self, request, queryset):
		if not request.user.is_superuser:
			self.message_user(request, 'Only a superuser can remove transfer records.', messages.ERROR)
			return None

		eligible = queryset.filter(
			branch__iexact='YEUKAI',
			status='pending',
			transfer_id__startswith='TRANSFER_',
		)
		if not eligible.exists():
			self.message_user(request, 'No pending YEUKAI transfers were selected.', messages.WARNING)
			return None

		return delete_selected(self, request, eligible)

	@admin.action(
		description='Delete selected pending YEUKAI stocktakes',
		permissions=['delete'],
	)
	def delete_pending_yeukai_stocktakes(self, request, queryset):
		if not request.user.is_superuser:
			self.message_user(request, 'Only a superuser can remove transfer records.', messages.ERROR)
			return None

		eligible = queryset.filter(
			branch__iexact='YEUKAI',
			status='pending',
			transfer_id__startswith='STOCKTAKE_',
		)
		if not eligible.exists():
			self.message_user(request, 'No pending YEUKAI stocktakes were selected.', messages.WARNING)
			return None

		return delete_selected(self, request, eligible)

	@admin.action(
		description='Delete selected failed YEUKAI commands',
		permissions=['delete'],
	)
	def delete_failed_yeukai_commands(self, request, queryset):
		if not request.user.is_superuser:
			self.message_user(request, 'Only a superuser can remove transfer records.', messages.ERROR)
			return None

		eligible = queryset.filter(branch__iexact='YEUKAI', status='failed').filter(
			Q(transfer_id__startswith='TRANSFER_')
			| Q(transfer_id__startswith='STOCKTAKE_')
		)
		if not eligible.exists():
			self.message_user(request, 'No failed YEUKAI commands were selected.', messages.WARNING)
			return None

		return delete_selected(self, request, eligible)

	def delete_queryset(self, request, queryset):
		if not request.user.is_superuser:
			raise PermissionDenied
		eligible = queryset.filter(
			Q(branch__iexact='Mini Market', status='pending')
			| Q(branch__iexact='YEUKAI', status__in=['pending', 'failed']) & (
				Q(transfer_id__startswith='TRANSFER_')
				| Q(transfer_id__startswith='STOCKTAKE_')
			)
		)
		super().delete_queryset(request, eligible)

	def delete_model(self, request, obj):
		is_pending_mini_market = obj.branch.casefold() == 'mini market' and obj.status == 'pending'
		is_pending_yeukai_transfer = (
			obj.branch.casefold() == 'yeukai'
			and obj.status in ('pending', 'failed')
			and obj.transfer_id.startswith(('TRANSFER_', 'STOCKTAKE_'))
		)
		if not request.user.is_superuser or not (is_pending_mini_market or is_pending_yeukai_transfer):
			raise PermissionDenied
		super().delete_model(request, obj)
