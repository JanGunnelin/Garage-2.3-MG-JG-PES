using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Garage_2_3_MG_JG_PES.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "Member-ID")]
        public int MemberId { get; set; }

        public virtual Member Member { get; set; }

        [Display(Name = "Type")]
        public int VehicleTypeID { get; set; }

        public virtual VehicleType VehicleType { get; set; }

        [Required]
        [Display(Name = "Registration Number")]
        [RegularExpression(pattern: "^[A-Za-z]{3}[0-9]{3}",
        ErrorMessage = "The registration number must start with 3 letters and end with 3 digits")]
        public string RegistrationNumber { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please input 3-10 letters")]
        public string Color { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please input 3-10 characters")]
        public string Brand { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please input 3-10 characters")]
        public string Model { get; set; }

        [Display(Name = "Number Of Wheels")]
        [Range(2, 30, ErrorMessage = "The vehicle must have at least two wheels")]
        public int NumberOfWheels { get; set; }

        [Display(Name = "Check-In Time")]
        public DateTime? CheckIn { get; set; }
    }
}