app.controller('userController',['$scope','userFactory', function($scope, userFactory){
  $scope.users = []
  userFactory.getUsers(function(data){
    $scope.users = data
  })
}])
