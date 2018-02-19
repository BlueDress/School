using CarDealer.Services;
using CarDealer.Web.Models.Logs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CarDealer.Web.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILogService logService;

        public LogsController(ILogService logService)
        {
            this.logService = logService;
        }

        [Authorize]
        [Route("logs/all/{pageNumber}")]
        public IActionResult All(int pageNumber, string search)
        {
            if (pageNumber <= 0 || this.logService.LogsCount() / 20 < pageNumber - 1)
            {
                pageNumber = 1;
            }

            var logs = this.logService.GetAllLogs(pageNumber);
            var totalPages = (int)Math.Ceiling((double)this.logService.LogsCount() / 20);
            var currentPage = pageNumber;

            if (search != null)
            {
                logs = logs.Where(l => l.User.ToLower().Equals(search.ToLower()));
            }

            return View(new LogPaginationModel
            {
                Logs = logs,
                CurrentPage = currentPage,
                TotalPages = totalPages
            });
        }

        [Authorize]
        [Route("logs/delete")]
        public IActionResult Delete()
        {
            this.logService.DeleteAllLogs();

            return Redirect("/logs/all/1");
        }
    }
}
