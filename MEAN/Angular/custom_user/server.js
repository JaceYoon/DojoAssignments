var express  = require( 'express' ),
    bp       = require('body-parser'),
    path     = require( 'path' ),
    root     = __dirname,
    PORT     = 8000,
    app      = express()

app.use(express.static(path.join(__dirname, "./client")))
app.use(express.static(path.join(__dirname, "./node_modules")))
app.use(bp.json())

app.listen(PORT, function(){
console.log(10,`listening on port ${PORT}`)
})
