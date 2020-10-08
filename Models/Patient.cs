using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Abrahamowicz.Models
{
    public class Patient
    {
        public int patientID { get; set; }
       [Display (Name ="First name")]
       [Required (ErrorMessage = "Patient first name is required")]
       [StringLength (20)]
        public string firstName { get; set; }
        [Display (Name = "Last Name")]
        [Required (ErrorMessage = "Patient last name is required")]
        [StringLength (20)]
        public string lastName { get; set; }
        [Display (Name = "Email")]
        [Required(ErrorMessage = "Enter your most current email")]
        [EmailAddress]
        public string email { get; set; }
        [Required (ErrorMessage ="Enter your address")]
        [StringLength (40)]
        public string streetAddress { get; set; }
        public virtual Doctor doctor { get; set; }
        public DateTime birthday { get; set; }

        public ICollection<Appointment> appointment { get; set; }



    }
}