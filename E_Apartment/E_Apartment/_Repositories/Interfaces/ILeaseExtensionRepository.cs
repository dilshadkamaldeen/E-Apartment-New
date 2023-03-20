using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface ILeaseExtensionRepository
    {
        void Add(LeaseExtensionModel leaseExModel);
        void Update(LeaseExtensionModel leaseExModel);
        void Delete(int id);
        IEnumerable<LeaseExtensionModel> GetAll();
        IEnumerable<LeaseExtensionModel> GetByValue(string value); //search by name or location
    }
}
