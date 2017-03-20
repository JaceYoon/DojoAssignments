from django.db import models
from ..LR.models import User

class SecretManager(models.Manager):
    def post_secret(self, Message, user_id):
        LoginUser = User.objects.get(id=user_id)
        Secret.objects.create(secret=Message["msg"],creator=LoginUser)

    def add_like(self, user_id, secret_id):
        LoginUser = User.objects.get(id=user_id)
        likedMessage = Secret.objects.get(id=secret_id)
        likedMessage.liked.add(LoginUser)
    def delete_secret(self, secret_id):
        msg_delete = Secret.objects.get(id=secret_id)
        msg_delete.delete()

class Secret(models.Model):
    secret = models.TextField()
    creator = models.ForeignKey(User, related_name="Secret_User")
    liked = models.ManyToManyField(User, related_name="Like_User")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = SecretManager()
