var mongoose = require('mongoose');

var DogSchema = new mongoose.Schema({
 name: {type:String, require:true,minlength:5},
 age: {type:Number, require:true,min:5},
 color: {type:String, require:true,minlength:5}
})

mongoose.model('Dog', DogSchema)
var Dog = mongoose.model('Dog')
