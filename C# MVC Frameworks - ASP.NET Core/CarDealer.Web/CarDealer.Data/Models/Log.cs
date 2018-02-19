using System;

namespace CarDealer.Data.Models
{
    public class Log
    {
        public int Id { get; set; }

        public string User { get; set; }

        public string Operation { get; set; }

        public string ModifiedTable { get; set; }

        public DateTime TimeOfModifying { get; set; }
    }
}
