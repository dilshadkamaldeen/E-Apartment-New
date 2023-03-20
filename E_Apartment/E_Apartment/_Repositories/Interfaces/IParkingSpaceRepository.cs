using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IParkingSpaceRepository
    {
        void Add(ParkingSpaceModel parkingSpaceModel);
        void Update(ParkingSpaceModel parkingSpaceModel);
        void Delete(int id);
        IEnumerable<ParkingSpaceModel> GetAll();
        IEnumerable<ParkingSpaceModel> GetByValue(string value); //search by name or location
        void AddParkingReservation(ParkingSpaceDetailModel model);
        void UpdateParkingReservation(ParkingSpaceDetailModel model);
        IEnumerable<ParkingSpaceDetailModel> GetAllParkingSpaceDetails();
    }
}
