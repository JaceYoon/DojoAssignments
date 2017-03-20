app.factory('productFactory', function(){
  var factory = {}
  factory.products = []
  factory.add = function(product,cb){
    console.log('im in facotry')
    factory.products.push(product)
    cb()
  }
  return factory
})
