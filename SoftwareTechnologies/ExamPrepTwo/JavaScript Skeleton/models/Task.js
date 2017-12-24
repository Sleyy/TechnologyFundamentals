const mongoose = require('mongoose');

let taskSchema = mongoose.Schema(
    {
        title:{type:String,required:true,minLength:1},
        comments:{type:String,required:true,minLength:1}
    }
);
let Task = mongoose.model('Task',taskSchema);

module.exports = Task;