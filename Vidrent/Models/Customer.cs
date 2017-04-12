using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;

namespace Vidrent.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribesToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display (Name = "Membership Type")]
        public byte MembershipId { get; set; }
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    
    }
}