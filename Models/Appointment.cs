using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalEF.Models
{
    public class Appointment
    {
        
        public int Id { get; set; }//Primary ID
        public string FirstName { get; set; }
        [Required]
        public int PatientsID { get; set; }
        public Patients Patients { get; set; }
        [Required]
        public string Diseases { get; set; }
        public DateTime DateIn { get; set; }


    }
}
