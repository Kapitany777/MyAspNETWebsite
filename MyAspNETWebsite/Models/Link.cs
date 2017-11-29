using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.Models
{
    public class Link
    {
        public string LinkName { get; set; }
        public string URL { get; set; }

        public Link(string linkName, string url)
        {
            this.LinkName = linkName;
            this.URL = url;
        }
    }
}