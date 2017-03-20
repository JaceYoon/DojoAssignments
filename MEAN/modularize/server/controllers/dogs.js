var mongoose = require('mongoose')
var Dog = mongoose.model('Dog')
module.exports = {
  main: function(req,res){
    Dog.find({}, function(err, all){
      if(err) {
        console.log(1,'you are wrong')
      }
      else{
        res.render('index', {dogs:all})
      }
    })
  },
  createpage: function(req,res){
    res.render("new")
  },
  create: function(req,res){
    var dog = new Dog({name: req.body.name, age: req.body.age, color: req.body.color})
    dog.save(function(err){
      if(err){
        console.log(3,dog.errors)
      }
      else{
        console.log('successfully regi your dog!')
        res.redirect('/')
      }
    })
  },
  show: function(req,res){
    Dog.findOne({ _id: req.params.id }, function(err, all){
      if(err){
        console.log(4,Dog.errors)
      }
      else{
        console.log(5,all)
        console.log(6,'Here is your dog')
        res.render('show', {dogs:all})
      }
    })
  },
  edit: function(req,res){
    Dog.findOne({ _id: req.params.id}, function(err, all){
      if(err){
        console.log(7,'err!!')
      }
      else{
        console.log(8,all)
        res.render('edit', {dogs:all})
      }
    })
  },
  update: function(req,res){
    console.log(9,req.params.id)
    Dog.update({ _id: req.params.id }, req.body, function(err, all){
      // if (err) { console.log(err) }
      res.redirect('/')
    })
  },
  remove: function(req,res){
    Dog.remove({ _id: req.params.id}, function(err, all){
      console.log(req.params.id)
      res.redirect('/')
    })
  }
}
