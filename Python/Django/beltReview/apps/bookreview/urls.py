from django.conf.urls import url
from . import views
urlpatterns = [
    url(r'^$', views.index, name="home"),
    url(r'^add$', views.add, name="add"),
    url(r'^logout$', views.logout, name="logout"),
    url(r'^create$', views.create, name="create"),
    url(r'^review$', views.review, name="review"),
    url(r'^user$', views.user, name="user"),
]
