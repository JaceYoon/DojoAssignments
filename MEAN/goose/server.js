var express = require("express"),
    path = require("path"),
    app = express(),
    bodyParser = require("body-parser"),
    mongoose = require('mongoose'),
    PORT = 8000
mongoose.Promise = global.Promise
mongoose.connect('mongodb://localhost/puppys')

var DogSchema = new mongoose.Schema({
 name: {type:String, require:true,minlength:5},
 age: {type:Number, require:true,min:5},
 color: {type:String, require:true,minlength:5}
})
mongoose.model('Dog', DogSchema)
var Dog = mongoose.model('Dog')
app.use(bodyParser.urlencoded({ extended: true }))
app.use(express.static(path.join(__dirname, "./client")))

app.use(express.static('./static'))
app.set("views", path.join(__dirname, "./client/views"))
app.set("view engine", "ejs")

module.exports = function(app){
//homepage
  app.get("/", function (req, res){
    Dog.find({}, function(err, all){

      if(err) {
        console.log(1,'you are wrong')
      }
      else{

        // console.log(all);
        res.render('index', {dogs:all})
      }
    })
  })
  //create page
  app.get("/new", function (req, res){
    res.render("new")
  })
  app.post('/create', function (req,res){
  console.log(2,"POST DATA", req.body)
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
  })
  //show page
  app.get("/dog/:id", function (req, res){
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
  })

  app.get("/:id/edit", function(req,res){

    Dog.findOne({ _id: req.params.id}, function(err, all){
      if(err){
        console.log(7,'Ian')

      }
      else{
        console.log(8,all)
        res.render('edit', {dogs:all})
      }
    })
  })
  // app.post("/change/:id", function(req,res){
  //   Dog.findOne({ _id: req.params.id}, function(err, mydog){
  //    mydog.name = req.body.newname;
  //    mydog.age = req.body.newage;
  //    mydog.color = req.body.newcolor;
  //    mydog.save();
  //    res.redirect('/')
  //    console.log(mydog, '***************')
  //   })
  // }) ** you can do this way instead of below code **
  app.post('/change/:id', function(req, res){
    console.log(9,req.params.id)
    Dog.update({ _id: req.params.id }, req.body, function(err, all){
      // if (err) { console.log(err) }
      res.redirect('/')
    })
  })

  app.get('/:id/delete', function(req, res){
    console.log('Im here**')
    Dog.remove({ _id: req.params.id}, function(err, all){
      console.log(req.params.id)
      res.redirect('/')
    })
  })
}
app.listen(PORT, function(){
  console.log(10,`listening on port ${PORT}`)
})
