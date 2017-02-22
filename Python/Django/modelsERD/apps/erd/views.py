from django.shortcuts import render
from .models import User, Message, Comment
# Create your views here.
def index(request):
    render(request, "erd/index.html")
