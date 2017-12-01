using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int BirthDate { get; set; }
        public string Profession { get; set; }
        public string City { get; set; }
        public string HomePage { get; set; }
        public string LinkedinProfile { get; set; }

        public List<Qualification> Qualifications { get; set; }
    }
}
