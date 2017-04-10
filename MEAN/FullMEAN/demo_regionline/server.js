var mongoose = require( 'mongoose' ),
    express  = require( 'express' ),
    bp       = require('body-parser'),
    path     = require( 'path' ),
    session = require( 'express-session' ),
    root     = __dirname,
    PORT     = 8000,
    app      = express()

app.use(express.static(path.join(__dirname, "./client")))
app.use(express.static(path.join(__dirname, "./node_modules")))
app.use(session({
  secret: 'keyboard cat',
  resave: true,
  saveUninitialized: false,
  cookie: { secure: false }
}))
app.use(bp.json())
require('./server/config/mongoose.js')
require('./server/config/routes.js')(app)

app.listen(PORT, function(){
console.log(10,`listening on port ${PORT}`)
})
