var express = require("express"),
    path = require("path"),
    app = express(),
    bp = require("body-parser"),
    mongoose = require('mongoose'),
    PORT = 8000

app.use(express.static(path.join(__dirname, "./client")))
app.use(express.static(path.join(__dirname, "./node_modules")))
app.use(bp.json())

require('./server/config/mongoose.js')
require('./server/config/routes.js')(app)

app.listen(PORT, function(){
  console.log(10,`listening on port ${PORT}`)
})
