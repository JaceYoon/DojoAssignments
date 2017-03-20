from django.conf.urls import url,include
from . import views
urlpatterns = [
    url(r'^$', views.index, name="home"),
    url(r'^product/$', views.product, name="product"),
    url(r'^product/new/$', views.new, name="new"),
    url(r'^product/show/(?P<id>\w+)/$', views.show, name="show"),
    url(r'^product/edit/(?P<id>\w+)/$', views.edit, name="edit"),
    url(r'^product/create/$', views.create, name="create"),
    url(r'^product/remove/(?P<id>\w+)/$', views.remove, name="remove"),
    url(r'^product/confirm/(?P<id>\w+)/$', views.confirm, name="confirm"),
    url(r'^product/update/(?P<id>\w+)/$', views.update, name="update"),

]
