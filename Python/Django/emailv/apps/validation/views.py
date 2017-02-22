from django.shortcuts import render,redirect
from django.contrib import messages
from .models import Email
# Create your views here.

def index(request):
    return render(request, "validation/index.html")

def go(request):
    if Email.emailManage.ValidEmail(request.POST['email']):
        Email.emailManage.create(email=request.POST['email'])
        messages.success(request, 'The email address you entered : ' + request.POST['email'] + ' is a VALID email, Thank you!')
        return redirect('home:pas')
    else:
        messages.warning(request, 'Invalid email! Try again')
        return redirect('/')
def pas(request):
    context = {
        "email" : Email.emailManage.all()
    }
    return render(request, 'validation/pass.html', context)
