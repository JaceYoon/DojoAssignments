var mongoose = require('mongoose')
var Schema = mongoose.Schema

var userSchema = new mongoose.Schema({
    name : {type:String, required: true, maxlength:15, minlength:4},
    product1_bids: [{type: Schema.Types.ObjectId, ref: 'Product1'}],
    product2_bids: [{type: Schema.Types.ObjectId, ref: 'Product2'}],
    product3_bids: [{type: Schema.Types.ObjectId, ref: 'Product3'}]
}, {timestamps: true} )

mongoose.model('User', userSchema)
