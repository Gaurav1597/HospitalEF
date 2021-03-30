using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HospitalEF.Models
{
    public class Patients//model for Patients
    {
        [Key]
        public int Id { get; set; }//Primary Id
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Diseases { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        // public StaffNames StaffName { get; set; }
    }
}
