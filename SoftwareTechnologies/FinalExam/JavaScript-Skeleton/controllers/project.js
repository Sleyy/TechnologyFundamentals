const Project = require('../models/Project');

module.exports = {
    index: (req, res) => {
       Project.find().then(projects=>{
           return res.render('project/index',{'projects':projects})
       })
    },
    createGet: (req, res) => {
        res.render('project/create');
    },
    createPost: (req, res) => {
        let project = req.body;
        Project.create(project).then(project=>{
            res.redirect("/");
        })
    },
    editGet: (req, res) => {
        Project.findById(req.params.id).then(project =>{
            res.render('project/edit',project)
        })
    },
    editPost: (req, res) => {
        Project.findByIdAndUpdate(req.params.id,req.body).then(project=>{
            res.redirect("/")
        }
        )
    },
    deleteGet: (req, res) => {
        Project.findById(req.params.id).then(project =>{
            res.render('project/delete',project)
        })
    },
    deletePost: (req, res) => {
        Project.findByIdAndRemove(req.params.id,req.body).then(project=>{
                res.redirect("/")
            }
        )
    }
};