from django.shortcuts import render,redirect
from ..LR.models import User
from .models import Item
from django.contrib import messages
# Create your views here.
def index(request):
    if 'id' not in request.session:
        messages.error(request, 'Must be logged in')
        return redirect('home:index')
    else:
        context = {
            "items" : Item.objects.filter(wishlist__id=request.session['id']),
            "users" : User.objects.all(),
            "otheritems" : Item.objects.exclude(wishlist__id=request.session['id'])
        }
        return render(request, "belt/main.html", context)

def logout(request):
    request.session.clear()
    return redirect('home:index')

def add(request):
    return render(request, "belt/add.html")

def additem(request, id):
    viewsResponse = Item.objects.post_item(request.POST, request.session["id"])
    if viewsResponse['isRegistered']:
        request.session['item'] = viewsResponse['item'].itemname
        wish_id = Item.objects.get(id=id)
        Item.objects.add_wish(wish_id, request.session["id"])
        return redirect('belt:main')
    else:
        for error in viewsResponse['errors']:
            messages.error(request, error)
        return redirect('belt:add')
def delete(request, id):
    item_id = id
    Item.objects.delete_item(item_id)
    return redirect('belt:main')

def addwish(request, id):
    wish_id = Item.objects.get(id=id)
    Item.objects.add_wish(wish_id, request.session["id"])
    return redirect('belt:main')

def deletelist(request,id):
    wish_id = id
    Item.objects.delete_item(wish_id)
    return redirect('belt:main')

def info(request,id):
    wish_id = id
    context = {
        "lists": Item.objects.filter(wishlist__id=request.session["id"]),
        "users": User.objects.filter(user_wishs__id=wish_id),
        "wish": Item.objects.get(id=wish_id),
    }
    return render(request, "belt/info.html", context)
