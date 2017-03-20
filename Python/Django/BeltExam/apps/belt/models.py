from django.db import models
from ..LR.models import User

class ItemManager(models.Manager):
    def post_item(self, Item, user_id):
        errors = []
        if len(Item['item']) < 3 :
            errors.append("Item name must be at least 3 characters")
        check_item = self.filter(itemname = Item['item'])
        if check_item:
            errors.append("Your Item is already in list")

        modelsResponse = {}

        if errors:
            modelsResponse['isRegistered'] = False
            modelsResponse['errors'] = errors

        else:
            LoginUser = User.objects.get(id=user_id)
            item = self.create(itemname = Item['item'], creator = LoginUser)
            modelsResponse['isRegistered'] = True
            modelsResponse['item'] = item

        return modelsResponse

    def delete_item(self, item_id):
        item_delete = Item.objects.get(id=item_id)
        item_delete.delete()

    def remove_wish(self, wish_id):
        user_wish = Item.objects.get(id=wish_id)
        user_wish.wishlist.clear()

    def add_wish(self, wishitem, user_id):
        LoginUser= User.objects.get(id=user_id)
        user_wish = wishitem
        user_wish.wishlist.add(LoginUser)
        user_wish.save()

# Create your models here.
class Item(models.Model):
    itemname = models.CharField(max_length=200)
    creator = models.ForeignKey(User, related_name="User_Items")
    wishlist = models.ManyToManyField(User, related_name="user_wishs")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ItemManager()
