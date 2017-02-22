from django.conf.urls import url
from . import views
urlpatterns = [
    url(r'^$', views.index),
    url(r'^hit$', views.hit , name='hit'),
    url(r'^remove/(?P<id>\w+)/$', views.remove , name='remove'),
    url(r'^confirm/(?P<id>\w+)/$', views.confirm, name='confirm'),
]
