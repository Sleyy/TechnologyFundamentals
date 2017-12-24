const Film = require('../models/Film');

module.exports = {
	index: (req, res) => {
        Film.find().then(films=>{
            return res.render('film/index',{'films':films})
        }).catch(error=>
        {
            return res.render('film/index', {films});
        });
	},
	createGet: (req, res) => {
        res.render("film/create");
	},
	createPost: (req, res) => {
		let film = req.body;
		Film.create(film).then(film=>{
			res.redirect("/");
		}).catch(error=>{
			res.render('film/create',film)
		});
	},
	editGet: (req, res) => {
       let filmId = req.params.id;

       Film.findById(filmId).then(film => {
	   if(film){
       	res.render('film/edit',film);
	   }
		else {
       	res.redirect('/');
	   }})
	},
	editPost: (req, res) => {
		let filmId = req.params.id;
		let film = req.body;

		Film.findByIdAndUpdate(filmId,film,{runValidators: true}).then(film=>{
			res.redirect("/");
		}).catch(err=>{
			film.id=filmId;
			return res.redirect("film/edit",film);
		})

	},
	deleteGet: (req, res) => {
        let filmId = req.params.id;

        Film.findById(filmId).then(film => {
            if(film){
                res.render('film/delete',film);
            }
            else {
                res.redirect('/');
            }})
	},
	deletePost: (req, res) => {
        let filmId = req.params.id;
        let film = req.body;

        Film.findByIdAndRemove(filmId,film).then(film=>{
            res.redirect("/");
        }).catch(err=>{
            res.redirect("/");
        })
	}
};