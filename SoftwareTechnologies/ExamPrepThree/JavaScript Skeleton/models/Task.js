const mongoose = require('mongoose');

let taskSchema = mongoose.Schema({

    status:{type:String,required:true},
    title:{type:String,required:true}
});

let Task = mongoose.model('Task', taskSchema);

module.exports = Task;