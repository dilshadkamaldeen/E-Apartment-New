using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Utility
{
    public class ModelValidator
    {
        public ModelValidator() { }
        public void Validate(object model) {

            string errorMessage = "";
            List<ValidationResult> result = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model,validationContext, result , true);
            if (!isValid)
            {
                foreach(ValidationResult validationResult in result)
                {
                    errorMessage +="- "+ validationResult.ErrorMessage +" \n";

                }

                throw new Exception(errorMessage);
            }


        }
    }
}
