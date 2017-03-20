var mongoose = require('mongoose');

var FriendSchema = new mongoose.Schema( {
  first_name: {type: String, required:true, minlength: 3},
  last_name: {type: String, required:true, minlength: 3},
  birthday: {type: Date, required:true}
})

mongoose.model('Friend', FriendSchema)
var Friend = mongoose.model('Friend')
