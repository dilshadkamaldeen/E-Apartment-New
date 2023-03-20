using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class TenantsModel
    {
        public int TenantId { get; set; }
        public string TenantName { get; set; }
        public string TenantNIC { get; set; }
        public string TenantContact { get; set; }
        public string TenantAddress { get; set; }
        public string TenantGender { get; set; }
        public bool TenantStatus { get; set; }
    }
}
