using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface ITenantsRepository
    {
        void Add(TenantsModel tanentsModel);
        void Update(TenantsModel tanentsModel);
        void Delete(int id);
        IEnumerable<TenantsModel> GetAll();
        IEnumerable<TenantsModel> GetByValue(string value); //search by name or location
    }
}
