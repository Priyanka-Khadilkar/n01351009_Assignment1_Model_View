using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGrooming.Models
{
    public class Pet
    {

        [Key]
        public int PetID { get; set; }
        public string PetName { get; set; }
        public double PetWeight { get; set; }
        public string PetColor { get; set; }
        public string PetNotes { get; set; }
    }
}
