using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class LeaseExtensionModel
    {
        public int LeaseExtensionId { get; set; }
        public int LeaseAgreementId { get; set; }
        public int TenantId { get; set; }
        public int ExtensionMonths { get; set; }
        public string ExtensionStatus { get; set; }
    }
}
