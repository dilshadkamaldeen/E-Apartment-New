using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class ParkingSpaceModel
    {
        public int ParkingId { get; set; }
        public string ParkingName { get; set; }
        public int ParkingSize { get; set; }
        public string ParkingType { get; set; }
        public bool IsReserved { get; set; }
        public bool ParkingStatus { get; set; }
        public string ParkingFeedback { get; set; }
        public ParkingSpaceDetailModel ParkingSpaceDetail { get; set; }
       
    }

    
}
