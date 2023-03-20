using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IReservationView
    {

        //Reservation properties
        int ReservationId { get; set; }
        DateTime ReservationDate { get; set; }
        string ReservationFee { get; set; }       
        string ReservationTenantId { get; set; }
        string ReservationApartmentId { get; set; }
        string ReservationStatus { get; set; }
        bool IsReservationFeePaid { get; set; }
        string ReservationApartmentStatus { get; set; }
        int ReservationBuildingId { get; set; } 
        
        bool IsWaitingList { get; set; }


        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }




        //Apartment properties
        int buildingId { get; set; }
        int? apartmentId { get; set; }
        int apartmentClassId { get; set; }
        string apartmentClassName { get; set; }
        string apartmentMaxNoOcc { get; set; }
        string apartmentRentPerMonth { get; set; }
        string apartmentDiningArea { get; set; }
        string apartmentLivingArea { get; set; }
        string apartmentKitchenArea { get; set; }
        string apartmentBedroomCount { get; set; }
        string apartmentCommonBathroom { get; set; }
        string apartmentAttachBathroom { get; set; }
        string servantsRoomCount { get; set; }
        string servantToiletCount { get; set; }
        string apartmentStatus { get; set; }
        string apartmentNo { get; set; }
        string reservationFee { get; set; }



        //Events
        event EventHandler SearchEventReservation;
        event EventHandler AddNewEventReservation;
        event EventHandler DeleteEventReservation;
        event EventHandler UpdateEventReservation;
        event EventHandler CancelEventReservation;
        event EventHandler SaveEventReservation;
        event EventHandler SaveEventApplicationReservation;
        event EventHandler buildingComboChange;
        event EventHandler apartmentComboChange;


        //Methods
        void SetLeaseBindingSource(BindingSource bindingSource);
        void SetTenantsNamesIntoComboBox(BindingSource bindingSource);
        void SetBuildingsIntoComboBox(BindingSource bindingSource);
        void SetApartmentNoIntoComboBox(BindingSource bindingSource);


        //buildings methods
        void SetReservationListBindingSource(BindingSource buildingList);
        void Show(); //Optional


        //apartments methods
        void SetReservationNamesIntoComboBox(BindingSource buildingList);


    }
}
