from django.db import models
import re,bcrypt
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
NAME_REGEX = re.compile(r'^[a-zA-Z]$')
# Create your models here.

class UserManager(models.Manager):
    def ValidForm(self, userData):
        errors = []
        if not userData['first_name'].isalpha():
            errors.append('First name should be characters')
        if not len(userData['last_name']):
            errors.append('Last name is required')
        if not userData['last_name'].isalpha():
            errors.append('Last name should be characters')
        if not len(userData['email']):
            errors.append('Email required!')
        if not EMAIL_REGEX.match(userData['email']):
            errors.append('Invalid Email!')
        check_email = self.filter(email = userData['email'])
        if check_email:
            errors.append('Sorry .. Email is already exists!')
        if not len(userData['password']):
            errors.append('Please enter the Password')
        if len(userData['password']) < 8:
            errors.append('Password must be at least 8 long')
        if not userData['password'] == userData['confirm']:
            errors.append('Passwords must match!')

        modelsResponse = {}

        if errors:
            modelsResponse['isRegistered'] = False
            modelsResponse['errors'] = errors
        else:
            hashed_password = bcrypt.hashpw(userData['password'].encode(), bcrypt.gensalt())
            user = self.create(first_name = userData['first_name'], last_name = userData['last_name'], email = userData['email'], password = hashed_password)
            modelsResponse['isRegistered'] = True
            modelsResponse['user'] = user

        return modelsResponse

    def login_user(self, userData):
        user = self.filter(email = userData['email'])
        errors = []
        modelsResponse = {}
        if not user:
            errors.append('Invalid email')
        else:
            if bcrypt.checkpw(userData['password'].encode(), user[0].password.encode()):
                modelsResponse['isLoggedIn'] = True
                modelsResponse['user'] = user[0]

            else:
                errors.append('Email or Password is not correct')

        if errors:
            modelsResponse['isLoggedIn'] = False
            modelsResponse['errors'] = errors

        return modelsResponse


class User(models.Model):
    first_name = models.CharField(max_length=200)
    last_name = models.CharField(max_length=200)
    email = models.EmailField()
    password = models.CharField(max_length=200)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = UserManager()
