app.controller('sessionController', function($scope, sessionFactory){
  sessionFactory.checkStatus(function(data){
    $scope.curUser = data
  })

  $scope.login = function(){
    if(!$scope.user || ! $scope.user.name || $scope.user.name.length < 3){
      alert('name should be at least 3')
    }else{
      sessionFactory.login($scope.user)
    }
  }

})
