using CarDealer.Services.Models;
using System;
using System.Collections.Generic;

namespace CarDealer.Services
{
    public interface ILogService
    {
        int LogsCount();

        void Add(string user, string operation, string modifiedTable, DateTime dateModified);

        IEnumerable<LogModel> GetAllLogs(int pageNumber);

        void DeleteAllLogs();
    }
}
