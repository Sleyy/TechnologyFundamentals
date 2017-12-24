using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
    [ValidateInput(false)]

    public class TaskController : Controller
    {


        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var db = new TodoListDbContext();

            var model = db.Tasks.ToList();

            return View(model);
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
        public ActionResult Create(Task task)
        {
            if (!ModelState.IsValid)
            {
                return View(task);
            }

            var db = new TodoListDbContext();

            Task currentTask = new Task();

            currentTask.Title = task.Title;
            currentTask.Comments = task.Comments;

            db.Tasks.Add(currentTask);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            var db = new TodoListDbContext();
            if (!db.Tasks.Any(x => x.Id == id))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            var currentTask = db.Tasks.Find(id);

            return View(currentTask);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var db = new TodoListDbContext();

            if (!db.Tasks.Any(x => x.Id == id))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Task currentTask = db.Tasks.Find(id);

            db.Tasks.Remove(currentTask);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}