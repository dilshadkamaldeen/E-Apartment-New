using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IDependentsRepository
    {
        void Add(DependentsModel dependentsModel);
        void Update(DependentsModel dependentsModel);
        void Delete(int id);
        IEnumerable<DependentsModel> GetAll();
        IEnumerable<DependentsModel> GetByValue(string value); //search by name or location
    }
}
