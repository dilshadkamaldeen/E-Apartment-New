using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class ParkingSpaceDetailModel
    {
        
            public int ParkingSpaceId { get; set; }
            public int LeaseAgreementId { get; set; }
            public DateTime ReservedDate { get; set; }
        public bool ParkingSpaceDetailStatus { get; internal set; }
    }
}
