using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class ApartmentModel
    {

        public int ApartmentId { get; set; }
        public int ApartmentClassId { get; set; }
        public int ApartmentBuildingId { get; set; }
        public int ApartmentNo { get; set; }
        public decimal ApartmentRentPerMonth { get; set; }
        public int MaxNumberOccupied { get; set; }
        public string Status { get; set; }
        public bool IsLivingArea { get; set; }
        public decimal LivingAreaSqft { get; set; }
        public bool IsDiningArea { get; set; }
        public decimal DiningAreaSqft { get; set; }
        public bool IsKitchenArea { get; set; }
        public decimal KitchenAreaSqft { get; set; }
        public bool IsLaundryArea { get; set; }
        public decimal LaundryAreaSqft { get; set; }
        public bool IsTelephoneService { get; set; }
        public bool IsBroadbandInternet { get; set; }
        public bool IsCableTv { get; set; }
        public bool IsParkingArea { get; set; }
        public bool IsGymnasium { get; set; }
        public bool IsSwimingPool { get; set; }
        public decimal ReservationFee { get; set; }

        //for join query (forign key)
        public ApartmentClassModel apartmentClass { get; set; }
        public BuildingsModel buildingsModel { get; set; }


    }
}
