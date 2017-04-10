var mongoose = require( 'mongoose' ),
    User = mongoose.model( 'User' )

module.exports = (function(){
  return{
    login:function(req,res){
      User.findOne({name: req.body.name}, function(err, data){
        if(!data){
          var user = new User(req.body)
          user.save(function(err, data){
            req.session.user = data
            req.session.save()
            res.json(data)
          })
        }else{
          if(req.body.password == data.password){
            console.log("Welcome to my world")
            req.session.user = data
            req.session.save()
            res.json(data)
          }else{
            console.log("good try tomato")
            res.redirect('/')
          }
        }
      })
    },
    checkStatus: function(req, res){
      if(req.session.user){
        res.json(req.session.user)
      }else{
        res.json(null)
      }
    },
    logout: function(req, res){
      req.session.destroy()
      res.redirect('/')
    }
  }
})()
