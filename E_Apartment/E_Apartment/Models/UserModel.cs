using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    internal class UserModel
    {
        public int UserId { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]

        public string UserPassword { get; set; }
        [Required(ErrorMessage = "User Type Required")]
        public string UserType { get; set; }
        public bool UserStatus { get; set; }

        public int? CustomerId { get; set; }
    }
}
