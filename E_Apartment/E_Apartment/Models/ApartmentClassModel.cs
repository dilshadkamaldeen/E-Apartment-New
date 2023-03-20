using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    public class ApartmentClassModel
    {
        public int ClassNameId { get; set; }
        public string ClassName { get; set; }
        public bool IsBedroomAvailable { get; set; }
        public int BedroomCount { get; set; }
        public bool IsCommonBathroomAvailable { get; set; }
        public int CommonBathroomCount { get; set; }
        public bool IsAttachBathroomAvailalbe { get; set; }
        public int AttachBathroomCount { get; set; }
        public bool IsServantsRoomAvailable { get; set; }
        public int ServantsRoomCount { get; set; }
        public bool IsServantToiletAvailable { get; set; }
        public int ServantToiletCount { get; set; }
        public bool Status { get; set; }






        /// <summary>
        /// Encapsulation
        /// </summary>

        //[DisplayName("Class Name Id")]
        //public int Id { get => classNameId; set => classNameId = value; }

        //[DisplayName("Class Name")]
        //[Required(ErrorMessage = "Apartment Class Name is Required")]
        //public string ClassName { get => className; set => className = value; }


        //[DisplayName("isBedroomAvailable")]
        //[Required(ErrorMessage = "IsBedroomAvailable is Required")]
        //public bool IsBedroomAvailable { get => isBedroomAvailable; set => isBedroomAvailable = value; }


        //[DisplayName("bedroomCount")]
        //public int BedroomCount { get => bedroomCount; set => bedroomCount = value; }


        //[DisplayName("Is Common Bathroom Available")]
        //public bool IsCommonBathroomAvailable { get => isCommonBathroomAvailable; set => isBedroomAvailable = value; }


        //[DisplayName("Common Bathroom Count")]
        //public int CommonBathroomCount { get => commonBathroomCount; set => commonBathroomCount = value; }


        //[DisplayName("Is Attach Bathroom Availalbe")]
        //public bool IsAttachBathroomAvailalbe { get => isAttachBathroomAvailalbe; set => isBedroomAvailable = value; }


        //[DisplayName("Attach Bathroom Count")]
        //public int AttachBathroomCount { get => attachBathroomCount; set => bedroomCount = value; }


        //[DisplayName("Is Servants Room Available")]
        //public bool IsServantsRoomAvailable { get => isServantsRoomAvailable; set => isBedroomAvailable = value; }


        //[DisplayName("Servants Room Count")]
        //public int ServantsRoomCount { get => servantsRoomCount; set => commonBathroomCount = value; }


        //[DisplayName("Is Servant Toilet Available")]
        //public bool IsServantToiletAvailable { get => isServantToiletAvailable; set => isBedroomAvailable = value; }


        //[DisplayName("Servant Toilet Count")]
        //public int ServantToiletCount { get => servantToiletCount; set => bedroomCount = value; }


        //[DisplayName("Status")]
        //public bool Status { get => status; set => status = value; }


    }
}
