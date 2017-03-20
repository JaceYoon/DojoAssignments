from django.conf.urls import url
from . import views
urlpatterns = [
    url(r'^$', views.index, name="home"),
    url(r'^secret$', views.secret, name="secret"),
    url(r'^like/(?P<id>\w+)/$', views.like, name="like"),
    url(r'^delete/(?P<id>\w+)/$', views.delete, name="delete"),
]
