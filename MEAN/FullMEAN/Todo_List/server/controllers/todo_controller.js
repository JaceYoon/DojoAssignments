var mongoose = require('mongoose')
var Todo = mongoose.model('Todo')
var User = mongoose.model('User')

module.exports = (function(){
  return {
    create: function(req, res){
      var user_id = req.session.user._id
      var newTodo = new Todo({
        title : req.body.title,
        duedate : req.body.duedate,
        description : req.body.description
      })
      newTodo._user = user_id
      newTodo.save(function(err,data){
        if(err){
          console.log(err)
        }else{
          User.update({_id:user_id}, {$push: {'items':newTodo}}, function(err){

          })
          console.log(newTodo,"todo added")
          res.json(data)
        }
      })
    },

    show: function(req,res){
      Todo.find({}, function(err, todo){
        res.json(todo)
      })
    },
    
  }
})()
