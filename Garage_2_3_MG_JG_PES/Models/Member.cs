using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Garage_2_3_MG_JG_PES.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; }

       // public string FullName { get { return FirstName + " " + LastName; } }
        // Navigational property
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}