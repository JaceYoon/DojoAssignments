from __future__ import unicode_literals
from ..LR.models import User
from django.db import models

class BookManager(models.Manager):
    def add_book(self, userData):
        errors = []
        selected_authorlist = userData['authorlist']
        if not len(userData['title']):
            errors.append('Title cannot be blank')
        if not len(userData['review']):
            errors.append('Please tell me about the book')
        if selected_authorlist == 'none':
            if not len(userData['newauthor']):
                errors.append('Select the author from list or put the your author please')
        if not selected_authorlist == 'none':
            if len(userData['newauthor']):
                errors.append('You already selected author you cannot put the new author')
        if len(userData['review']) < 5:
            errors.append('Your Review is too short')

        check_author = self.filter(newauthor = userData['newauthor'])

        if check_author:
            errors.append('Your author is already exsist on list')

        modelsResponse = {}

        if errors:
            modelsResponse['isRegistered'] = False
            modelsResponse['errors'] = errors

        else:
            if len(userData['newauthor']):
                book = self.create(title = userData['title'], newauthor = userData['newauthor'], review = userData['review'], rating = userData['rating'])
                modelsResponse['isRegistered'] = True
                modelsResponse['book'] = book

            if not len(userData['newauthor']):
                book = self.create(title = userData['title'], newauthor = userData['authorlist'], review = userData['review'], rating = userData['rating'])
                modelsResponse['isRegistered'] = True
                modelsResponse['book'] = book

        return modelsResponse

# Create your models here.

class Book(models.Model):
    title = models.CharField(max_length=50)
    rating = models.IntegerField()
    review = models.TextField()
    user = models.ManyToManyField(User, related_name="created_by")
    newauthor = models.CharField(max_length=50)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = BookManager()
