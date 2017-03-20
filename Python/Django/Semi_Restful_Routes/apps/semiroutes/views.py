from django.shortcuts import render,redirect
from .models import Products
from django.core.urlresolvers import reverse
# Create your views here.
def index(request):
    return redirect('/product')

def product(request):
    context = {
        'name' : Products.objects.all(),
    }
    return render(request,"semiroutes/product.html", context)

def new(request):
    return render(request,"semiroutes/new.html")

def create(request):
    if request.method == "POST":
        Products.objects.add_product(request.POST)

    return redirect('/product')
def show(request, id):
    context = {

        'list': Products.objects.filter(id=id),
    }
    return render(request,"semiroutes/show.html",context)

def edit(request, id):
    context = {

        'list': Products.objects.filter(id=id),
    }
    return render(request,"semiroutes/edit.html",context)

def remove(request, id):
    context = {
        
        'list': Products.objects.filter(id=id),
    }
    return render(request,"semiroutes/remove.html",context)

def confirm(request, id):
    Products.objects.remove_product(id)
    return redirect('/product')

def update(request, id):
    if request.method == 'POST':
        Products.objects.update_product(request.POST, id)
    return redirect('/product')
