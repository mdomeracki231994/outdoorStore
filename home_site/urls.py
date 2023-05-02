from django.urls import path
from home_site import views

urlpatterns = [
    path('', views.index),
]