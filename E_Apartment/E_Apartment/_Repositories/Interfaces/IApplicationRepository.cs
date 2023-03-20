using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IApplicationRepository
    {
        void Add(ApplicationModel applicationModel);
        void Update(ApplicationModel applicationModel);
        void Delete(int id);
        IEnumerable<ApplicationModel> GetAll();
        IEnumerable<ApplicationModel> GetByValue(string value); //search by name or location
    }
}
