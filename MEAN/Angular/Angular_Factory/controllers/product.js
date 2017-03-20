app.controller('productController', function($scope, productFactory){
  $scope.products = productFactory.products
  $scope.add = function(){
    console.log($scope.new_product)
    productFactory.add($scope.new_product, function(){
      $scope.products = productFactory.products
      console.log($scope.products)
    })
    $scope.new_product = {}
  }
  $scope.remove = function(idx){
    var product_delete = $scope.products[idx]
    $scope.products.splice($scope.products.indexOf(product_delete),1)
  }
})
