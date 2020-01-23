using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
       
        public int OwnerID { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerWorkPhoneNumber { get; set; }
        public string OwnerHomePhoneNumber { get; set; }
        public string OwnerEmail { get; set; }

    }
}
