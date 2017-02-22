from django.conf.urls import url
from . import views
urlpatterns = [
    url(r'^$', views.index),
    url(r'^pas$', views.pas, name= 'pas'),
    url(r'^go$', views.go, name = 'go'),
]
