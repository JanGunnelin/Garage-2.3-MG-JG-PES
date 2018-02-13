using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Garage_2_3_MG_JG_PES.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public VehicleType VehicleType { get; set; }

        [Required]
        [RegularExpression(pattern:"^[A-Za-z]{3}[0-9]{3}", 
        ErrorMessage = " RegNr bör innehålla tre bokstäver samt tre siffror")]
        public string RegistrationNumber { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Använd 5 -10 bokstäver")]
        public string Color { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Använd 5 -10 bokstäver")]
        public string Brand { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Använd 5 -10 bokstäver")]
        public string Model { get; set; }

        [Range(2,30, ErrorMessage = "Fordonet får inte ha färre hjul än två....")]
        public int NumberOfWheels { get; set; }

       
        public DateTime CheckIn { get; set; }
       
    }
}