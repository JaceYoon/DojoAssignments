var app=angular.module('app', ['ngRoute'])

app.config(function ($routeProvider) {
  $routeProvider
    .when("/", {
      redirectTo:'/login'
    })
    .when("/login", {
      controller : 'userController',
      templateUrl : './partials/login.html'
    })
    .when("/add", {
      controller : 'todoController',
      templateUrl : './partials/add.html'
    })
    .when("/dash", {
      templateUrl : './partials/dashboard.html'
    })
    .otherwise({
      redirectTo:'/'
    })
})
