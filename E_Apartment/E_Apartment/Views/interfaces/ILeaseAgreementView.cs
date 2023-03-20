using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface ILeaseAgreementView
    {
        int LeaseAgreementId { get; set; }
        int ReservationId { get; set; }
        int TenantId { get; set; }
        decimal RefundableDeposit { get; set; }
        decimal FirstMonthRent { get; set; }
        decimal TotalAdvanceAmount { get; set; }
        bool IsTotalAdvancePaid { get; set; }
        string Term { get; set; }
        DateTime LeaseStartDate { get; set; }
        DateTime LeaseExpireDate { get; set; }
        decimal TotalDueAmount { get; set; }
        bool IsAllocateDefaultParking { get; set; }
        bool LeaseAgreementStatus { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }




        #region Others
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
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        int reservationId { get; set; }
        string tenantsId { get; set; }
        string tenantsName { get; set; }
        string buildingName { get; set; }


        //Events
        event EventHandler SearchEventLeaseAgreement;
        event EventHandler AddNewEventLeaseAgreement;
        event EventHandler DeleteEventLeaseAgreement;
        event EventHandler EditEventLeaseAgreement;
        event EventHandler CancelEventLeaseAgreement;
        event EventHandler SaveEventLeaseAgreement;
        event EventHandler UpdateEventLeaseAgreement;
        event EventHandler buildingComboChange;
        event EventHandler leaseComboChange;
        event EventHandler apartmentComboChange;


        void SetLeaseBindingSource(BindingSource bindingSource);
        void SetTenantsNamesIntoComboBox(BindingSource bindingSource);
        void SetBuildingsIntoComboBox(BindingSource bindingSource);
        void SetApartmentNoIntoComboBox(BindingSource bindingSource);
        void SetReservationIntoComboBox(BindingSource bindingSource);

        #endregion 
        void Show(); //Optional

        #region Views
        
        #endregion
    }
}
