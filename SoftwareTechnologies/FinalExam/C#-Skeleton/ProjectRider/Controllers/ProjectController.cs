namespace ProjectRider.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ProjectController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var db = new ProjectRiderDbContext(); ;
            var projects = db.Projects.ToList();
            return View(projects);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            var db = new ProjectRiderDbContext();

            if (this.ModelState.IsValid)
            {
                db.Projects.Add(project);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            var db = new ProjectRiderDbContext();

            Project currentProject = db.Projects.Where(x => x.Id == id).First();

            return View(currentProject);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Project project)
        {
            var db = new ProjectRiderDbContext();

            Project currentProject = db.Projects.Where(x => x.Id == id).First();

            if (this.ModelState.IsValid)
            {
                currentProject.Budget = project.Budget;
                currentProject.Description = project.Description;
                currentProject.Title = project.Title;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Edit");


        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var db = new ProjectRiderDbContext();

            Project currentProject = db.Projects.Where(x => x.Id == id).First();

            return View(currentProject);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Project reportModel)
        {
            var db = new ProjectRiderDbContext();

            Project currentProject = db.Projects.Find(id);

            db.Projects.Remove(currentProject);
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}