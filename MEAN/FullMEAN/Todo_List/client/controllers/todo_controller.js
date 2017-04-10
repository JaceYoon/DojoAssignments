app.controller('todoController',['$scope','todoFactory', function($scope, todoFactory){

    $scope.errors = []
    $scope.todos = []

    var index = function() {
      todoFactory.getTodos(function(data){
        $scope.todos = data
      })
    }

    index()

    $scope.create = function(){
      $scope.errors = []
      if(!$scope.todo || !$scope.todo.title){
        $scope.errors.push('Please put the title')
      }
      else if($scope.todo.title.length < 3){
        $scope.errors.push('Todo title is too short')
      }
      else if(!$scope.todo.duedate){
        $scope.errors.push('Please select your due_date')
      }
      else if(!$scope.todo.description){
        $scope.errors.push('Please put the description')
      }
      else{
        todoFactory.create($scope.todo)
      }
    }

    $scope.show = function(id){
      todoFactory.show(id)
    }

}])
