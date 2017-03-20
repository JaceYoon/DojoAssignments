var mongoose = require('mongoose')
var Friend = mongoose.model('Friend')

module.exports = {
  index: function(req, res) {
    Friend.find({}, function(err, friends) {
      if (err) {
        console.log(err)
      } else {
        res.json(friends);
      }
    })
  },
  create: function(req, res) {
    var friend = new Friend( {
      first_name:req.params.first_name,
      last_name:req.params.last_name,
      birthday:req.params.birthday
    })
    friend.save(function(err, results) {
      if(err) {
        console.log("Nope")
      } else {
        console.log("Added: " + friend.name)
        res.redirect('/')
      }
    })
  },
  update: function(req, res) {
    Friend.findOne({ _id: req.params.id}, function(err, friend){
      if(err){
        console.log(err)
      }
      else{
        friend.first_nam e= req.body.first_name,
        friend.last_name = req.body.first_name,
        friend.birthday = req.body.birthday

        friend.save(function(err, updateFriend){
          if(err){
            console.log(err)
          }
          else{
            res.json(updateFriend)
          }
        })
      }
    })
    res.json({placeholder:'update'})
  },
  destroy: function(req, res) {
    Friend.remove({ _id: req.params.id, function(err, results) {
      if (err) {
        console.log(err)
      } else {
        console.log('Specified friend deleted')
        res.redirect('/')
      }
    })
  },
  show: function(req, res) {
    Friend.findOne({_friend: req.params.id}, function(err, friend) {
      if (err) {
        console.log(err)
      } else {
        console.log('Specified name shown')
        res.json(friend)
      }
    })
  }
}
