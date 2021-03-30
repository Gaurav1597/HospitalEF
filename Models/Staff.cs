using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HospitalEF.Models
{
    public class Staff//model For Staff Page
    {
        
        public int Id { get; set; }//Primary ID
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Post { get; set; }
        public string Department { get; set; }

    }
}
