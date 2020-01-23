using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        [Key]
        public int GroomerID { get; set; }
        public string GroomerFirstName { get; set; }
        public string GroomerLastName { get; set; }
        public DateTime GroomerDateOfBirth { get; set; }
        public int GroomerRate { get; set; }
        public string GroomerEmail { get; set; }
    }
}
