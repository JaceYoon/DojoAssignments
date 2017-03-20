app.factory('friendsFactory', ['$http','$location', function($http, $location, $route) {
  var factory = {};
  factory.friends = []
  factory.index = function(callback) {
      $http.get('/friends').then(function(returned_data){
        factory.friends = returned_data.data
        callback(factory.friends)
      });
  }
  factory.show = function() {

  }
  factory.create = function(newfriend, callback) {
    $http.post('/friends', newfriend).then(function(returned_data){
      console.log(returned_data.data)
      if (typeof(callback) == 'function'){
        callback(returned_data.data)
      }
    })
  }
  factory.update = function(id, callback) {
    // $http.put(/*ROUTE*/).then(function(returned_data) {
    //     console.log(returned_data.data);
    //     if (typeof(callback) == 'function'){
    //       callback(returned_data.data)
    //     }
    // })
  }
  factory.delete = function(id) {
    $http.delete('/friends/'+id).then(function(){
      $route.reload()
    })
  }
  return factory;
}])
