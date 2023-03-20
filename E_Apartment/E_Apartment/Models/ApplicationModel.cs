using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class ApplicationModel
    {        
        public int ApplicationId { get; set; }
        public int ApplicationBuildingId { get; set; }
        public int ApplicationApartmentId { get; set; }
        public string ApplicationApartmentStatus { get; set; }  
        public int ApplicationTenantId { get; set; }
        public bool IsWaitingList { get; set; }
        public DateTime ApplyDate { get; set; }
    }
}
