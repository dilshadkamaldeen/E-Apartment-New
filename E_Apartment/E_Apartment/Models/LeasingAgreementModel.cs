using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class LeasingAgreementModel
    {
        
       
        public int LeaseAgreementId { get; set; }
        public int ReservationId { get; set; }
        public int TenantId { get; set; }
        public decimal RefundableDeposit { get; set; }
        public decimal FirstMonthRent { get; set; }
        public decimal TotalAdvanceAmount { get; set; }
        public bool IsTotalAdvancePaid { get; set; }
        public string Term { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime LeaseExpireDate { get; set; }
        public decimal TotalDueAmount { get; set; }
        public bool IsAllocateDefaultParking { get; set; }
        public bool LeaseAgreementStatus { get; set; }

        public TenantsModel Tenants { get; set; }
        public ReservationModel Reservation { get; set; }

    }
}
