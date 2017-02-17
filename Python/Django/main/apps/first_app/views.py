from django.shortcuts import render, HttpResponse

def index(request):
    print ("Jace"*5)
    return render(request, "first_app/index.html")

# Create your views here.
