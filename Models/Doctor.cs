using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Abrahamowicz.Models
{
    public class Doctor
    {
        public int doctorID { get; set; }
        [Display (Name ="First Name")]
        [Required (ErrorMessage ="Doctor first name is required")]
        [StringLength (20)]
        public string firstName { get; set; }
        [Display (Name ="Last Name")]
        [Required (ErrorMessage ="Doctor last name is required")]
        [StringLength (20)]
        public string lastName { get; set; }
        [Display (Name ="Specialty")]
        [Required (ErrorMessage ="Doctor's specialty is required")]
        [StringLength (20)]
        public string specialty { get; set; }
        [Display (Name = "Office Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required (ErrorMessage ="Phone number is required")]
        [RegularExpression(@"^(\(\d{3}\)|\d{3}-)\d{3}-\d{4}$", 
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxx")]
            
        


        public string officePhone { get; set; }
        public ICollection<Patient> Patient { get; set; }


    }
}