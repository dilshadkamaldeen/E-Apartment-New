using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class DependentsModel
    {
        public int DependentId { get; set; }
        public int TenantId { get; set; }
        public string DependentName { get; set; }
        public string DependentRelationship { get; set; }
        public string DependentGender { get; set; }
        public bool DependentStatus { get; set; }
    }
}
