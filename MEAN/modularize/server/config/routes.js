var mongoose = require('mongoose')
var Dog = mongoose.model('Dog')
var Dogs = require('../controllers/dogs.js');
module.exports = function(app){
//homepage
  app.get("/", function (req, res){
    Dogs.main(req, res)
  })
//create page
  app.get("/new", function (req, res){
    Dogs.createpage(req, res)
  })
  app.post('/create', function (req,res){
    Dogs.create(req, res)
  })
  //show page
  app.get("/dog/:id", function (req, res){
    Dogs.show(req,res)
  })

  app.get("/:id/edit", function(req,res){
    Dogs.edit(req,res)
  })
  app.post('/change/:id', function(req, res){
    Dogs.update(req,res)
  })
  app.get('/:id/delete', function(req, res){
    Dogs.remove(req,res)
  })
}
