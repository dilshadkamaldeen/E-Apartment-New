using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IApartmentView
    {
        //Events
        event EventHandler SearchEventApartment;
        event EventHandler AddNewEventApartment;
        event EventHandler DeleteEventApartment;
        event EventHandler EditEventApartment;
        event EventHandler CancelEventApartment;
        event EventHandler SaveEventApartment;


        //Fields

        int ApartmentId { get; set; }
        int ApartmentClassId { get; set; }
        int ApartmentBuildingId { get; set; }
        int ApartmentNo { get; set; }
        decimal ApartmentRentPerMonth { get; set; }
        int MaxNumberOccupied { get; set; }
        string ApartmentStatus { get; set; }
        bool IsLivingArea { get; set; }
        decimal LivingAreaSqft { get; set; }
        bool IsDiningArea { get; set; }
        decimal DiningAreaSqft { get; set; }
        bool IsKitchenArea { get; set; }
        decimal KitchenAreaSqft { get; set; }
        bool IsLaundryArea { get; set; }
        decimal LaundryAreaSqft { get; set; }
        bool IsTelephoneService { get; set; }
        bool IsBroadbandInternet { get; set; }
        bool IsCableTv { get; set; }
        bool IsParkingArea { get; set; }
        bool IsGymnasium { get; set; }
        bool IsSwimingPool { get; set; }

        string Message { get; set; }
        bool IsSuccess { get; set; }
        bool IsApartmentEdit { get; set; }
        decimal ReservationFee { get; set; }



        //Methods
        void SetApartmentListBindingSource(BindingSource apartmentList);

    }
}
