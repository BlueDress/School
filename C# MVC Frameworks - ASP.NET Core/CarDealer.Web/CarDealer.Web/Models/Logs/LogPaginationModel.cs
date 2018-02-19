using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Web.Models.Logs
{
    public class LogPaginationModel
    {
        public IEnumerable<LogModel> Logs { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int NextPage => this.CurrentPage == this.TotalPages ? this.CurrentPage : this.CurrentPage + 1;

        public int PreviousPage => this.CurrentPage == 1 ? 1 : this.CurrentPage - 1;
    }
}
