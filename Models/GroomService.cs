using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
     
        public int GroomServiceID { get; set; }
        public string GroomServiceName { get; set; }
        public int GroomServiceCost { get; set; }
        public int GroomServiceDuration { get; set; }
    }
}
