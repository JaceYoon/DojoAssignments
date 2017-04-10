var app = angular.module('app', ['ngRoute'])
app.config(function ($routeProvider) {
  $routeProvider
    .when("/", {
      templateUrl : './partials/main.html',
      controller : 'newController'
    })
    .when("/new", {
      templateUrl : './partials/new.html',
      controller : 'newController'
    })
    .when("/show", {
      templateUrl : './partials/show.html'
    })
    .otherwise({
      redirectTo:'/'
    })
})

// app.controller('FriendController', function($scope, FriendFactory, $location){
//   $scope.friends = FriendFactory.friends
//   console.log($location)
//   $scope.add_friend = function(){
//     FriendFactory.add($scope.friend, function(){
//       $scope.friends = FriendFactory.friends
//     })
//     $scope.friend = {}
//   }
//
//   $scope.remove_friend = function(id){
//     $scope.friends.splice(id,1)
//   }
// })
