using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface IReservationRepository
    {
        void Add(ReservationModel reservationModel);
        
        void Update(ReservationModel reservationModel);
        void Delete(int id);
        IEnumerable<ReservationModel> GetAll();
        IEnumerable<ReservationModel> GetByValue(string value); //search by name or location


        //Others
        IEnumerable<BuildingsModel> GetAllBuildings();
        IEnumerable<ApartmentClassModel> GetAllApartmentClass();
        IEnumerable<ApartmentModel> GetAllApartment();
        IEnumerable<ApartmentModel> GetAllApartmentByBuildingId(int buildingId);
        IEnumerable<ApartmentModel> GetApartmentById(int apartmentId);
        IEnumerable<TenantsModel> GetAllTenants();
    }
}
