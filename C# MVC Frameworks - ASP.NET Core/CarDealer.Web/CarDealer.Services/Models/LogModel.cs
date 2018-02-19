using System;

namespace CarDealer.Services.Models
{
    public class LogModel
    {
        public string User { get; set; }

        public string Operation { get; set; }

        public string ModifiedTable { get; set; }

        public DateTime TimeOfModifying { get; set; }
    }
}
