from django.shortcuts import render, redirect
from .models import Course
# Create your views here.
def index(request):
    context = {
        'name' : Course.objects.all()
    }
    return render(request,"course/index.html", context)

def hit(request):
    if request.method == 'POST':
        Course.objects.create(name = request.POST['name'],
        description = request.POST['description'])
    return redirect('/')

def remove(reqeust, id):
    context = {
        "name" : Course.objects.get(id=id)
    }
    return render(reqeust,"course/remove.html", context)

def confirm(reqeust, id):
    getid = Course.objects.get(id=id)
    getid.delete()
    return redirect('/')
