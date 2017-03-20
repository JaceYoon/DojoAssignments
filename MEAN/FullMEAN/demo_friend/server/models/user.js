var mongoose = require('mongoose')
// console.log(mongoose)
var Schema = mongoose.Schema
var UserSchema = new Schema({
  name:{type:String, required: true, maxlength:30, minlength:4}
})

mongoose.model('User', UserSchema)
