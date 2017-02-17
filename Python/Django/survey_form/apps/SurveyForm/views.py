from django.shortcuts import render, redirect

# Create your views here.
def index(request):
    return render(request, 'SurveyForm/index.html')

def survey(request):
    if not 'count' in request.session:
        request.session['count'] = 0
    return render(request, 'SurveyForm/result.html')

def info(request):
    if request.method == "POST":
        request.session['name'] = request.POST['name']
        request.session['location'] = request.POST['location']
        request.session['language'] = request.POST['language']
        request.session['comment'] = request.POST['comment']
        request.session['count'] += 1
        return redirect('/result')
    else:
        return redirect('/')
