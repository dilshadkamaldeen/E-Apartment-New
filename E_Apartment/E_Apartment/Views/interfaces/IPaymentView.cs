using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IPaymentView
    {

        int PaymentId { get; set; }
        string PaymentType { get; set; }
        decimal PaidAmount { get; set; }
        DateTime PaidDate { get; set; }
        bool IsReservationFeePayment { get; set; }
        int ReservationId { get; set; }
        bool IsDuePayment { get; set; }
        int LeaseAgreementId { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }


        //Events
        event EventHandler SearchEventPayment;
        event EventHandler AddNewEventPayment;
        event EventHandler EditEventPayment;
        event EventHandler DeleteEventPayment;
        event EventHandler UpdateEventPayment;
        event EventHandler CancelEventPayment;
        event EventHandler SaveEventPayment;

        //Methods

        //buildings methods
        void SetPaymentListBindingSource(BindingSource paymentList);
        void Show(); //Optional

    }
}
