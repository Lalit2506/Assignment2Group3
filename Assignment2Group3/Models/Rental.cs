using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2Group3.Models
{
    public class Rental
    {
        [Required]
        public virtual int Rentalid { get; set; }

        [Required]
        public virtual String Type { get; set; }

        [Required]
        public virtual String Address { get; set; }

        [Required]
        public virtual Double Price { get; set; }

        [Required]
        public virtual String location { get; set; }

        [Required]
        public virtual String Description { get; set; }
    }
}