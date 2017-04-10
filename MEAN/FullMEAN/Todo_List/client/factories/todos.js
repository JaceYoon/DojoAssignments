app.factory('todoFactory', function($http,$location){
  var factory = {}
  factory.create = function(todo){
      $http.post('/create', todo).then(function(output){
        if(output.data){
          $location.url('/dash')
        }
      })
  },

  factory.getTodos = function(cb){
    $http.get('/gettodos').then(function(output){
      cb(output.data)
    })
  },

  factory.show = function(id){
    $location.url('/show/'+id)
  }
  return factory
})
