using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        private IMDBDbContext db = new IMDBDbContext();

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var films = db.Films.ToList();
            return View(films);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            if (this.ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View();
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var film = db.Films.Where(x => x.Id == id).First();
            return View(film);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            if (this.ModelState.IsValid)
            {
                var film = db.Films.Where(x => x.Id == id).First();

                film.Director = filmModel.Director;
                film.Genre = filmModel.Genre;
                film.Name = filmModel.Name;
                film.Year = filmModel.Year;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit",filmModel);

        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var film = db.Films.Find(id);
            return View(film);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Film filmModel)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
           
            return Redirect("/");
        }
    }
}