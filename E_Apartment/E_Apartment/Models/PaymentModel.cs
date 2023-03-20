using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class PaymentModel
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime PaidDate { get; set; }
        public bool IsReservationFeePayment { get; set; }
        public int ReservationId { get; set; }
        public bool IsDuePayment { get; set; }
        public int LeaseAgreementId { get; set; }
    }
}
