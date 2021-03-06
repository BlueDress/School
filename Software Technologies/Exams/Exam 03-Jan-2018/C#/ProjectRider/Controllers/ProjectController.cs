﻿namespace ProjectRider.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ProjectController : Controller
    {
        private ProjectRiderDbContext db = new ProjectRiderDbContext();

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (db)
            {
                var projects = db.Projects.ToList();
                return View(projects);
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
        public ActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                using (db)
                {
                    db.Projects.Add(project);
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
                var project = db.Projects.Find(id);
                if (project != null)
                {
                    return View(project);
                }
            }
            return Redirect("/");
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Project project)
        {
            if (!ModelState.IsValid)
            {
                return View(project);
            }

            using (db)
            {
                var projectFromDb = db.Projects.Find(project.Id);
                if (projectFromDb != null)
                {
                    projectFromDb.Title = project.Title;
                    projectFromDb.Description = project.Description;
                    projectFromDb.Budget = project.Budget;
                    db.SaveChanges();
                }
            }
            return Redirect("/");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (db)
            {
                var project = db.Projects.Find(id);
                if (project != null)
                {
                    return View(project);
                }
            }
            return Redirect("/");
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Project reportModel)
        {
            using (db)
            {
                var project = db.Projects.Find(id);
                if (project != null)
                {
                    db.Projects.Remove(project);
                    db.SaveChanges();
                }
            }
            return Redirect("/");
        }
    }
}