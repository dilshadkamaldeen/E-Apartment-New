using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; //for validation purpose

namespace E_Apartment.Models
{
    public class BuildingsModel
    {
        //Fields
        private int buildingId;
        private string buildingName;
        private string buildingLocation;
        private string buildingAddress;
        

        //Properties and Validation
        [DisplayName("Building Id")]
        public int Id { get => buildingId; set => buildingId = value; }

        [DisplayName("Building Name")]
        [Required(ErrorMessage ="Building Name is Required")]
        public string BuildingName { get => buildingName; set => buildingName = value; }

        [DisplayName("Building Location")]
        [Required(ErrorMessage = "Building Location is Required")]
        public string BuildingLocation { get => buildingLocation; set => buildingLocation = value; }

        [DisplayName("Building Address")]
        [Required(ErrorMessage = "Building Address is Required")]
        public string BuildingAddress { get => buildingAddress; set => buildingAddress = value; }
    }
}
