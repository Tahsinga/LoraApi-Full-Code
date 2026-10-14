from django.contrib import admin
from django.contrib import messages
from django.contrib.admin.actions import delete_selected
from django.core.exceptions import PermissionDenied

from .models import StockTransfer


@admin.register(StockTransfer)
class StockTransferAdmin(admin.ModelAdmin):
	list_display = (
		'transfer_id', 'branch', 'product_id', 'product_name', 'quantity',
		'target_quantity', 'status', 'created_at', 'claimed_at', 'completed_at',
	)
	list_filter = ('branch', 'status')
	search_fields = ('transfer_id', 'product_name', 'product_id')
	actions = ('delete_pending_mini_market_transfers',)

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

	def delete_queryset(self, request, queryset):
		if not request.user.is_superuser:
			raise PermissionDenied
		eligible = queryset.filter(branch__iexact='Mini Market', status='pending')
		super().delete_queryset(request, eligible)

	def delete_model(self, request, obj):
		if not request.user.is_superuser or obj.branch.casefold() != 'mini market' or obj.status != 'pending':
			raise PermissionDenied
		super().delete_model(request, obj)
