from django.shortcuts import render, redirect
from .models import Course
from ..LR.models import User
from django.core.urlresolvers import reverse
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
    return redirect('/course')

def remove(reqeust, id):
    context = {
        "name" : Course.objects.get(id=id)
    }
    return render(reqeust,"course/remove.html", context)

def confirm(reqeust, id):
    getid = Course.objects.get(id=id)
    getid.delete()
    return redirect('/course')

def course_user(request):
    context2 ={
        "users" : User.objects.all(),
        "courses" : Course.objects.all()
    }
    return render(request,"course/usercourse.html",context2)

def add(request):
    print "hello"
    if request.method == 'POST':
        print "bye"
        selected_user = User.objects.get(id=request.POST['user'])
        selected_course = Course.objects.get(id=request.POST['course'])
        selected_course.creator.add(selected_user)
        selected_course.save()
    return redirect(reverse('course:course_user'))
