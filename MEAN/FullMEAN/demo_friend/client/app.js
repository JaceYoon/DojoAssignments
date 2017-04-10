var app=angular.module('app', ['ngRoute'])

app.config(function ($routeProvider) {
  $routeProvider
    .when("/", {
      redirectTo:'/login'
    })
    .when("/login", {
      templateUrl : './partials/login.html',
    })
    .when("/dash", {
      templateUrl : './partials/dashboard.html'
    })
    .otherwise({
      redirectTo:'/'
    })
})
