from django.shortcuts import render,redirect

# Create your views here.
def home(request):
    return redirect('/ninjas')

def index(request):
    context = {
        "tmnt":"tmnt.png"
    }
    return render(request,"turtles/index.html",context)

def turtle(request,color):
    if color == "blue":
        context = {
        "tmnt":"leonardo.jpg"
        }
    elif color == "orange":
        context = {
        "tmnt":"michelangelo.jpg"
        }
    elif color == "red":
        context = {
        "tmnt":"raphael.jpg"
        }
    elif color == "purple":
        context = {
        "tmnt":"donatello.jpg"
        }
    else:
        context = {
        "tmnt":"notapril.jpg"
        }
    return render(request,"turtles/index.html",context)
