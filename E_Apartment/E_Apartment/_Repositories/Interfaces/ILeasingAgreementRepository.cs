using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories.Interfaces
{
    internal interface ILeasingAgreementRepository
    {
        void Add(LeasingAgreementModel leasingAgreementModel);
        void Update(LeasingAgreementModel leasingAgreementModel);
        void Delete(int id);
        IEnumerable<LeasingAgreementModel> GetAll();
        IEnumerable<LeasingAgreementModel> GetByValue(string value); //search by name or location

        IEnumerable<BuildingsModel> GetAllBuildings();
        IEnumerable<ApartmentClassModel> GetAllApartmentClass();
        IEnumerable<ApartmentModel> GetAllApartment();
        IEnumerable<ApartmentModel> GetAllApartmentByBuildingId(int buildingId);
        IEnumerable<ApartmentModel> GetApartmentById(int apartmentId);
        IEnumerable<ReservationModel> GetReservationById(int apartmentId);
        IEnumerable<TenantsModel> GetAllTenants();
        IEnumerable<ReservationModel> GetAllReservations();
    }
}
