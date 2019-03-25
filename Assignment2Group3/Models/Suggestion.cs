using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2Group3.Models
{
    public class Suggestion
    {
        [Required]
        public virtual int SuggestionID { get; set; }

        [Required]
        public virtual String Name { get; set; }

        [Required]
        public virtual String Comment { get; set; }
    }
}