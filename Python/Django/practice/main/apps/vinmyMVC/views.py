from django.shortcuts import render, redirect

# Create your views here.
def index(request):
    return render(request, 'vinmyMVC/index.html')

def show(request):
    print(request.method)
    return render(request, 'vinmyMVC/show_users.html')

def create(request):
    print(request.method)
    if request.method == "POST":
        print ('*' * 5)
        print (request.POST)
        request.session['name'] = request.POST['first_name']
        print ('*' * 5)
        return redirect('/',create)
    else:
        return redirect('/')
