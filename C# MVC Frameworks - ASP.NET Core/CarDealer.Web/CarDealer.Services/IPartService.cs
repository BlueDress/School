using CarDealer.Data.Models;
using CarDealer.Services.Models;
using System.Collections.Generic;

namespace CarDealer.Services
{
    public interface IPartService
    {
        void Create(string name, decimal price, Supplier supplier, int? quantity);

        IEnumerable<PartModel> Parts();

        PartModel GetPartById(int id);

        void Edit(int id, decimal price, int quantity);

        bool Exists(int id);

        void Delete(int id);
    }
}
