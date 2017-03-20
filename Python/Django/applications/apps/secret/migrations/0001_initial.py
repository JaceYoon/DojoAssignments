# -*- coding: utf-8 -*-
# Generated by Django 1.10.5 on 2017-02-24 02:19
from __future__ import unicode_literals

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        ('LR', '0001_initial'),
    ]

    operations = [
        migrations.CreateModel(
            name='Secret',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('secret', models.TextField()),
                ('created_at', models.DateTimeField(auto_now_add=True)),
                ('updated_at', models.DateTimeField(auto_now=True)),
                ('creator', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, related_name='Secret_User', to='LR.User')),
                ('liked', models.ManyToManyField(related_name='Like_User', to='LR.User')),
            ],
        ),
    ]
