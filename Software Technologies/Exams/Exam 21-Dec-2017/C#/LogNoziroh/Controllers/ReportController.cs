namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        private LogNozirohDbContext context = new LogNozirohDbContext();

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var reports = context.Reports.ToList();
            return View(reports);
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            var report = context.Reports.FirstOrDefault(r => r.Id == id);

            if (report != null)
            {
                return View(report);
            }

            return Redirect("/");
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
        public ActionResult Create(Report report)
        {
            if (ModelState.IsValid)
            {
                this.context.Reports.Add(report);
                this.context.SaveChanges();

                return Redirect("/");
            }

            return View();
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var report = context.Reports.FirstOrDefault(r => r.Id == id);

            if (report != null)
            {
                return View(report);
            }

            return Redirect("/");
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Report reportModel)
        {
            var report = context.Reports.FirstOrDefault(r => r.Id == id);

            if (report != null)
            {
                this.context.Reports.Remove(report);
                this.context.SaveChanges();

                return Redirect("/");
            }

            return View();
        }
    }
}