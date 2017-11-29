using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.Models
{
    public class Qualification
    {
        public string School { get; set; }
        public string Name { get; set; }

        public Qualification(string school, string name)
        {
            this.School = school;
            this.Name = name;
        }
    }
}
