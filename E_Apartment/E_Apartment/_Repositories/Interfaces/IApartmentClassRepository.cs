using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IApartmentClassRepository
    {
        void Add(ApartmentClassModel apartmentClassModel);
        void Update(ApartmentClassModel apartmentClassModel);
        void Delete(int id);
        IEnumerable<ApartmentClassModel> GetAll();
        IEnumerable<ApartmentClassModel> GetByValue(string value); //search by name or location
    }
}
