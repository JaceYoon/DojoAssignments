app.controller('sessionController', function($scope, sessionFactory){

    $scope.errors = []
    $scope.curUser = null
    sessionFactory.getUser(function(data){
      $scope.curUser = data
    })
    $scope.login = function(){
      $scope.errors = []
      if(!$scope.LogReg || !$scope.LogReg.name){
        $scope.errors.push('Please enter your name')
      }
      else if($scope.LogReg.name.length < 3){
        $scope.errors.push('Your name is too short')
      }
      else if($scope.LogReg.name.length > 8){
        $scope.errors.push('Your name is too long')
      }
      else{
        sessionFactory.login($scope.LogReg)
      }
    }

})
