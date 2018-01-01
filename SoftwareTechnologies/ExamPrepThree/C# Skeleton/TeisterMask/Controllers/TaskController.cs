using System;
using System.Linq;
using System.Web.Mvc;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
        [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
            [Route("")]
	    public ActionResult Index()
	    {
		    var db = new TeisterMaskDbContext();

	        var tasks = db.Tasks.ToList();

	        return View("Index", tasks);

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
		public ActionResult CreateTask(Task task)
		{
		    var db = new TeisterMaskDbContext();

		    if (this.ModelState.IsValid)
		    {
		        db.Tasks.Add(task);
		        db.SaveChanges();
		        return RedirectToAction("Index");
		    }

		    return View("Create");
		}

		[HttpGet]
		[Route("edit/{id}")]
        public ActionResult Edit(int id)
		{
            var db = new TeisterMaskDbContext();

		    Task currentTask = db.Tasks.Where(x => x.Id == id).First();
		    return View(currentTask);
		}

		[HttpPost]
		[Route("edit/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult EditConfirm(int id, Task taskModel)
		{
		    if (this.ModelState.IsValid)
		    {
		        var db = new TeisterMaskDbContext();

		        Task currentTask = db.Tasks.Where(x => x.Id == id).First();

		        currentTask.Status = taskModel.Status;
		        currentTask.Title = taskModel.Title;

		        db.SaveChanges();

		        return RedirectToAction("Index");
            }

		    return View("Edit");


		}
	}
}