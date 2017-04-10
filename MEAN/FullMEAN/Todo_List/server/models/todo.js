var mongoose = require('mongoose')
// console.log(mongoose)
var Schema = mongoose.Schema
var TodoSchema = new Schema({
  title : {type:String, required: true, maxlength:30, minlength:4},
  duedate : {type:Date, required: true},
  description : {type:String, required: true, maxlength:100},
  _user : [{type: mongoose.Schema.Types.ObjectId, ref: "User"}]
},{timestamp : true})

mongoose.model('Todo', TodoSchema)
