using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IApartmentRepository
    {
        void Add(ApartmentModel apartmentModel);
        void Update(ApartmentModel apartmentModel);
        void Delete(int id);
        IEnumerable<ApartmentModel> GetAll();
        IEnumerable<ApartmentModel> GetByValue(string value); //search by name or location
    }
}
