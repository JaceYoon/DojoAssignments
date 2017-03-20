var express = require("express")
var path = require("path")
var app = express()
var bodyParser = require("body-parser")
var PORT = 8000

app.use(bodyParser.urlencoded({ extended: true }))
app.use(express.static(path.join(__dirname, "./client")))
app.use(express.static(path.join(__dirname, "./node_modules")))

app.set("views", path.join(__dirname, "./client/views"))
app.set("view engine", "ejs")

app.get("/", function (req, res){
  res.render("index")
})
app.post('/result', function (req,res){
  // console.log("POST DATA", req.body)
  postData ={
    name : req.body.name,
    location : req.body.location,
    language : req.body.language,
    comment : req.body.comment
  }
  res.render('result',{Data:postData})
})
app.listen(PORT, function(){
  console.log(`listening on port ${PORT}`)
})
