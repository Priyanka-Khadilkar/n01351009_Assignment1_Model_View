using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetGrooming.Models
{
    public class GroomBookingService
    {

        [Key]
        public int GroomBookingServiceID { get; set; }
        public int GroomBookingID { get; set; }
        public int GroomServiceID { get; set; }
    }
}