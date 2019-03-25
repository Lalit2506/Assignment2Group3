using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2Group3.Models
{
    public class SuggestionList
    {
        public IEnumerable<Suggestion> Suggestion { get; set; }
        public Suggestion newPerson { get; set; }
    }
}