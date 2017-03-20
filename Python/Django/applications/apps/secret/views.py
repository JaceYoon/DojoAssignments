from django.shortcuts import render,redirect
from .models import Secret
from ..LR.models import User

# Create your views here.
def index(request):
    context = {
        "secrets" : Secret.objects.all(),
    }
    return render(request,"secret/secret.html", context)

def secret(request):
    if request.method == "POST":
        Secret.objects.post_secret(request.POST, request.session["id"])
    return redirect('secret:home')

def like(request,id):
    secret_id = id
    Secret.objects.add_like(request.session['id'], secret_id)
    return redirect('secret:home')

def delete(request, id):
    secret_id = id
    Secret.objects.delete_secret(secret_id)
    return redirect('secret:home')
