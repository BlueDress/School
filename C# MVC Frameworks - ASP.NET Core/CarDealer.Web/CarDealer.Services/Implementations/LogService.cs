using CarDealer.Data;
using CarDealer.Data.Models;
using CarDealer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarDealer.Services.Implementations
{
    public class LogService : ILogService
    {
        private readonly CarDealerDbContext db;

        public LogService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public void Add(string user, string operation, string modifiedTable, DateTime timeOfModifying)
        {
            var log = new Log
            {
                User = user,
                Operation = operation,
                ModifiedTable = modifiedTable,
                TimeOfModifying = timeOfModifying
            };

            this.db.Logs.Add(log);
            this.db.SaveChanges();
        }

        public IEnumerable<LogModel> GetAllLogs(int pageNumber)
        {
            return this.db.Logs.Skip((pageNumber - 1) * 20).Take(20).Select(l => new LogModel
            {
                User = l.User,
                Operation = l.Operation,
                ModifiedTable = l.ModifiedTable,
                TimeOfModifying = l.TimeOfModifying
            });
        }

        public int LogsCount()
        {
            return this.db.Logs.Count();
        }

        public void DeleteAllLogs()
        {
            this.db.Logs.RemoveRange(this.db.Logs);
            this.db.SaveChanges();
        }
    }
}
