var mongoose = require( 'mongoose' ),
    Schema = mongoose.Schema,
    UserSchema = new Schema({
      name: {type:String,
            require:[true, "you need name"],
            minlength: [3,"your name is too short"],
            trim: true},
      password: {type:String, require:true, minlength:4}
    })
mongoose.model('User', UserSchema)
