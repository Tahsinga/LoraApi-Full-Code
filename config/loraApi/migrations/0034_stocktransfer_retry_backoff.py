from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('loraApi', '0033_alter_stockmovement_movement_type'),
    ]

    operations = [
        migrations.AddField(
            model_name='stocktransfer',
            name='retry_count',
            field=models.PositiveIntegerField(default=0),
        ),
        migrations.AddField(
            model_name='stocktransfer',
            name='retry_after',
            field=models.DateTimeField(blank=True, null=True),
        ),
    ]