const Task = require('../models/Task');

module.exports = {
    index: (req, res) => {
        Task.find().then(tasks => {
            let openTasks = [];
            let inProgressTasks = [];
            let finishedTasks = [];

            for (let i = 0; i < tasks.length; i++) {
                let currentTask = tasks[i];

                if (currentTask.status === 'Open') {
                    openTasks.push(currentTask);
                }
                else if (currentTask.status === 'In Progress') {
                    inProgressTasks.push(currentTask);
                }
                else if (currentTask.status === 'Finished') {
                    finishedTasks.push(currentTask);
                }
            }
            res.render('task/index', {
                'openTasks': openTasks,
                'inProgressTasks': inProgressTasks,
                'finishedTasks': finishedTasks
            });

        });

},
	createGet: (req, res) => {
		return res.render('task/create');
	},
	createPost: (req, res) => {
		let task = req.body;
		Task.create(task).then(task=>{
			return res.redirect('/');
		})
	},
	editGet: (req, res) => {
		Task.findById(req.params.id).then(task=> {
            res.render('task/edit', task)
        })
	},
	editPost: (req, res) => {
		Task.findByIdAndUpdate(req.params.id,req.body).then(
			res.redirect('/')
		)
	}
};