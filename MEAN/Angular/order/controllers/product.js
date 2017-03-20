app.controller('productController', function($scope, productFactory){
  $scope.products = productFactory.products

  $scope.add = function(){
    productFactory.add($scope.new_product, function(){
      $scope.products = productFactory.products
    })
    $scope.new_product = {}
  }

  $scope.remove = function(id){
    $scope.products.splice(id,1)
  }
})

app.controller('orderController',['$scope','productFactory', function($scope, productFactory){
  $scope.products = productFactory.products

  $scope.buy = function(idx){
    productFactory.buy(idx,function(){
      $scope.products = productFactory.products
    })
  }
}])
