using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal interface IBuildingRepository
    {
        void Add(BuildingsModel buildingModel);
        void insert(BuildingsModel buildingModel);
        void Update(BuildingsModel buildingModel);
        void Delete(int id);
        IEnumerable<BuildingsModel> GetAll();
        IEnumerable<BuildingsModel> GetByValue(string value); //search by name or location
        
        
    }
}
