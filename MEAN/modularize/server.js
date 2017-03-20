var express = require("express"),
    path = require("path"),
    app = express(),
    bodyParser = require("body-parser"),
    mongoose = require('mongoose'),
    PORT = 8000

app.use(bodyParser.urlencoded({ extended: true }))
app.use(express.static('./static'))
app.set("views", path.join(__dirname, "./client/views"))
app.set("view engine", "ejs")

require('./server/config/mongoose.js')

var routes_setter = require('./server/config/routes.js');
routes_setter(app);

app.listen(PORT, function(){
  console.log(10,`listening on port ${PORT}`)
})
