app.controller('newController', ['$scope','friendsFactory','$location', function($scope, friendsFactory) {
  var index = function () {
      friendsFactory.index(function(data) {
          console.log(data);
          $scope.friends = data;
      })
  }
  index()
  $scope.create = function() {
      friendsFactory.create($scope.friend, function(data) {
          $scope.friends = data;
      })
      $scope.friend = {}
  }
  $scope.remove_friend = function(id){
    friendsFactory.delete(id)
  }
}])
