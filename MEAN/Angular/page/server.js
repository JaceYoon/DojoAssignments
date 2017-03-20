var express = require("express"),
    path = require("path"),
    app = express(),
    PORT = 8000

app.use(express.static(path.join(__dirname, "./client")))
app.use(express.static(path.join(__dirname, "./node_modules")))

app.listen(PORT, function(){
console.log(10,`listening on port ${PORT}`)
})
