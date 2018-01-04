using System;
using System.Linq;
using System.Web.Mvc;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
        [ValidateInput(false)]
	public class TaskController : Controller
	{
        private TeisterMaskDbContext db = new TeisterMaskDbContext();


        [HttpGet]
            [Route("")]
	    public ActionResult Index()
	    {
            using (db)
            {
                var tasks = db.Tasks.ToList();
                return View(tasks);
            }
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
            if (ModelState.IsValid)
            {
                using (db)
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    return Redirect("/");
                }
            }
            return View();
        }

		[HttpGet]
		[Route("edit/{id}")]
        public ActionResult Edit(int id)
		{
            using (db)
            {
                var task = db.Tasks.Find(id);
                if (task != null)
                {
                    return View(task);
                }
            }
            return Redirect("/");
        }

		[HttpPost]
		[Route("edit/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult EditConfirm(int id, Task task)
		{
            if (!ModelState.IsValid)
            {
                return View(task);
            }

            using (db)
            {
                var taskFromDb = db.Tasks.Find(task.Id);
                if (taskFromDb != null)
                {
                    taskFromDb.Title = task.Title;
                    taskFromDb.Status = task.Status;
                    db.SaveChanges();
                }
            }
            return Redirect("/");
        }
	}
}