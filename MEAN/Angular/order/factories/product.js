app.factory('productFactory', function(){
  var factory = {}
  factory.products = []
  factory.add = function(product,cb){
    product.quantity= 50
    factory.products.push(product)
    cb()
  }
  factory.buy = function(idx, cb){
    if(factory.products[idx].quantity > 0){
      factory.products[idx].quantity--
    }
    cb()
  }
  return factory
})
