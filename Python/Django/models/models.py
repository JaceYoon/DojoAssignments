from __future__ import unicode_literals

from django.db import models

class Author(models.Modl):
	name = models.CharField(max_length = 45)
	created_at = models.DateTimeField(auto_now_add = True)
	updated_at = models.DateTimeField(auto_now = True)

class Book(models.Model):
	title = models.CharField(max_length = 45)
	author = models.ForeignKey(Author, related_name = 'author_wrote')
	created_at = models.DateTimeField(auto_now_add = True)
	updated_at = models,DateTimeField(auto_now = True)