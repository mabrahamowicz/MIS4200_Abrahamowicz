using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Abrahamowicz.Models
{
    public class Appointment
    {
        [Key]
        public int appointmentID { get; set; }
        [Display(Name = "Treatment")]
        [Required(ErrorMessage = "Treatment type is required")]
        [StringLength(20)]

        public string treatment { get; set; }
        [Display(Name = "Appointment time")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter when the appointment was")]
        [DisplayFormat(DataFormatString ="{0:MM /dd /yyyy}",ApplyFormatInEditMode = true)]


        public DateTime date { get; set; }
        public decimal bill { get; set; }
        public int patientID { get; set; }
        public int doctorID { get; set; }
        public int MyProperty { get; set; }
        public virtual Patient patient { get; set; }
        public virtual Doctor doctor { get; set; }

    }
}