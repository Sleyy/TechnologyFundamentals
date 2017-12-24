const Task = require('../models/Task');

module.exports = {
    index: (req, res) => {
    	Task.find().then(tasks=>{
		return res.render('task/index', {'tasks': tasks})});
    },
	createGet: (req, res) => {
       return res.render('task/create');
	},
	createPost: (req, res) => {
        let task = req.body;
        Task.create(task).then(task=>{
        	res.redirect('/');
		})
	},
	deleteGet: (req, res) => {
        Task.findById(req.params.id).then(task=>{
        	if(task){
        	 res.render('task/delete',task);
		}
        else{
        		res.redirect('/');
			}
        })

	},
	deletePost: (req, res) => {
        Task.findByIdAndRemove(req.params.id).then(task=>{
        	return res.redirect('/')}
		);
	}
};