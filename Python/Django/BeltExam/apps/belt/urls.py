from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index, name="main"),
    url(r'^logout$', views.logout, name="logout"),
    url(r'^add$', views.add, name="add"),
    url(r'^additem$', views.additem, name="additem"),
    url(r'^addwish/(?P<id>\w+)/$', views.addwish, name="addwish"),
    url(r'^delte/(?P<id>\w+)/$', views.delete, name="delete"),
    url(r'^deletelist/(?P<id>\w+)/$', views.deletelist, name="deletelist"),
    url(r'^info/(?P<id>\w+)/$', views.info, name="info"),
]
