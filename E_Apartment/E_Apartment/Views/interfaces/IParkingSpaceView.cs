using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IParkingSpaceView
    {
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }


        //Data fields
        int ParkingId { get; set; }
        string ParkingName { get; set; }
        int ParkingSize { get; set; }
        string ParkingType { get; set; }
        bool IsReserved { get; set; }
        bool ParkingStatus { get; set; }


        //Parking Space Reservation Model Properties
        int ParkingSpaceId { get; set; }
        int LeaseAgreementId { get; set; }
        DateTime ReservedDate { get; set; }
        bool ParkingSpaceDetailStatus { get; set; }
        string ParkingSpaceFeedback { get; set; }

        //Events
        event EventHandler SearchEventParkingSpace;
        event EventHandler AddNewEventParkingSpace;
        event EventHandler DeleteEventParkingSpace;
        event EventHandler EditEventParkingSpace;
        event EventHandler CancelEventParkingSpace;
        event EventHandler SaveEventParkingSpace;
        event EventHandler UpdateEventParkingSpace;
        event EventHandler SaveEventParkingSpaceReservation;
        event EventHandler RefreshEventParkingSpaceReservation;

        //buildings methods
        void SetBindingSource(BindingSource bindingSource);
        void SetParkingSpaceReservationBindingSource(BindingSource bindingSource);
        void Show(); //Optional


    }
}
