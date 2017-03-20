var express = require("express"),
    path = require("path"),
    app = express(),
    bodyParser = require("body-parser"),
    mongoose = require('mongoose'),
    PORT = 8000
mongoose.Promise = global.Promise
mongoose.connect('mongodb://localhost/quotingdojo')

var DogSchema = new mongoose.Schema({
 name: {type:String, require:true,minlength:3},
 quote: {type:String, require:true}
})
mongoose.model('Quote', DogSchema)
var Quote = mongoose.model('Quote')
app.use(bodyParser.urlencoded({ extended: true }))
app.use(express.static(path.join(__dirname, "./client")))
app.use(express.static('./static'))
app.set("views", path.join(__dirname, "./client/views"))
app.set("view engine", "ejs")

//homepage
app.get("/", function (req, res){
      res.render('index')
  })

app.post("/create", function(req, res){
  var quote = new Quote({name: req.body.name, quote: req.body.quote})
  quote.save(function(err){
    if(err){
      console.log(3)
    }
    else{
      console.log('successfully regi!')
      res.redirect('/quotes')
    }
  })
})

app.get("/quotes", function(req,res){
  Quote.find({}, function(err,quotes){
    if(err){
      console.log("error happend")
    }
    else{
      res.render('quote',{que:quotes})
    }
  })
})

app.listen(PORT, function(){
  console.log(`listening on port ${PORT}`)
})
