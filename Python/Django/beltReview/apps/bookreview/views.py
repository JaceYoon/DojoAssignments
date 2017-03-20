from django.shortcuts import render,redirect
from ..LR.models import User
from .models import Book
from django.contrib import messages
# Create your views here.
def index(request):
    context = {
        "books" : Book.objects.all(),
        "users" : User.objects.all(),
    }
    if 'id' not in request.session:
        messages.error(request, 'Must be logged in')
        return redirect('home:index')
    return render(request,"bookreview/home.html",context)

def add(request):
    context = {
        "books" : Book.objects.all()
    }
    return render(request,"bookreview/add.html",context)

def logout(request):
    request.session.clear()
    return redirect('home:index')

def create(request):

    if request.method == 'POST':
        viewsResponse = Book.objects.add_book(request.POST)

        if viewsResponse['isRegistered']:
            return redirect('book:review')

        else:
            for error in viewsResponse['errors']:
                messages.error(request, error)
                return redirect('book:add')

def review(request):
    context = {
        "books" : Book.objects.all(),
        "users" : User.objects.all(),
    }
    return render(request, "bookreview/review.html",context)

def user(request):
    context = {
        "users" : User.objects.all()
    }
    return render(request, "bookreview/user.html", context)
