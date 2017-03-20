from django.db import models

class ProductManager(models.Manager):
    def add_product(self, postData):
        Products.objects.create(name=postData["name"], description=postData["description"],price=postData["price"])

    def update_product(self, postData, id):
        products = Products.objects.get(id=id)
        products.name = postData["name"]
        products.description = postData["description"]
        products.price = postData["price"]
        products.save()

    def remove_product(self, id):
        Products.objects.get(id=id).delete()
# Create your models here.
class Products(models.Model):
    name = models.CharField(max_length=255)
    description = models.TextField()
    price = models.DecimalField(max_digits=6, decimal_places=2)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ProductManager()
