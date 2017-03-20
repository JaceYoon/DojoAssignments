var express = require("express"),
    path = require("path"),
    app = express(),
    bp = require('body-parser'),
    PORT = 8000

app.use(express.static(path.join(__dirname, "./client")))
app.use(bp.json())
app.use(express.static(path.join(__dirname, "./node_modules")))

app.listen(PORT, function(){
  console.log(10,`listening on port ${PORT}`)
})
