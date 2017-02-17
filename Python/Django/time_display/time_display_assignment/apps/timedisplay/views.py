from django.shortcuts import render
import time
# Create your views here.
def index(request):

    clock = {
    "date" : time.strftime("%b/%d/%Y"),
    "time" : time.strftime("%I:%M %p")
    }
    return render(request, 'timedisplay/index.html',clock )
