from django.shortcuts import render


def index(request):
    return render(request, 'home_site/index.html')


def about(request):
    pass


def contact(request):
    pass
