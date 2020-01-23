using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        [Key]
        public int GroomBookingID { get; set; }
        public DateTime GroomBookingDate { get; set; }
        public int GroomBookingPrice { get; set; }
    }
}
