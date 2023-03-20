using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E_Apartment.Models
{
    internal class ReservationModel
    {        
        public int ReservationId { get; set; }
        public int ReservationBuildingId { get; set; }
        public int ReservationApartmentId { get; set; }
        public string ReservationApartmentStatus { get; set; }
        public decimal ReservationFee { get; set; }
        public bool IsReservationFeePaid { get; set; }
        public int ReservationTenantId { get; set; }
        public bool IsWaitingList { get; set; }

        //Forign Tables
        public TenantsModel Tenants { get; set; }
        public ApartmentModel Apartment { get; set; }

        public void Deconstruct(out TenantsModel tenants, out ApartmentModel apartment)
        {
            tenants = Tenants;
            apartment = Apartment;
        }
    }
}
