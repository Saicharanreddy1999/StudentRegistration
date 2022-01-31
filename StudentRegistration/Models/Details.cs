using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegistration.Models
{
    public class Details
    {
        [Required]
        [MaxLength(8)]
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string UniversityName { get; set; }
        [Required]
        public string CollegeName { get; set; }
        [Required]       
        public string Course { get; set; }  
    }
}