from django.conf.urls import url
from . import views
urlpatterns = [
    url(r'^$', views.home),
    url(r'^ninjas$', views.index),
    url(r'^ninjas/(?P<color>\w+)/$', views.turtle)
]
