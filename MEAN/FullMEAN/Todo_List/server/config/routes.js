var session = require('./../controllers/user_controller.js')
var todosession = require('./../controllers/todo_controller.js')
module.exports = function(app){
  app.post('/login', function(req, res){
    session.login(req, res)
  })

  app.get('/getuser', function(req, res){
    session.getUser(req, res)
  })

  app.get('/logout', function(req, res){
    session.logOut(req, res)
  })

  app.post('/create', function(req, res){
    todosession.create(req, res)
  })

  app.get('/gettodos', function(req, res){
    todosession.show(req, res)
  })

  app.get('/show/:id')
}
