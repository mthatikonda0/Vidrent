using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidrent.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if(customer.MembershipId == 0 || customer.MembershipId == 1)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("Date of Birth Is Required");
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return(age >= 18)
                ?ValidationResult.Success
              : new ValidationResult("customer shuld be at least 18");


        }
    }
}