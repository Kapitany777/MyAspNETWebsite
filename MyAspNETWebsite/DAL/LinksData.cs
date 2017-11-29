using MyAspNETWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.DAL
{
    public class LinksData
    {
        public List<Link> GetLinks()
        {
            List<Link> links = new List<Link>
            {
                new Link("Brain Cluster Inc.", "http://www.braincluster.eu/"),
                new Link("HTML5 Canvas", "http://www.html5canvas.eu/"),
                new Link("Retroszámítógépek", "http://www.retrocomputer.eu/"),
                new Link("Fantasy Books", "http://www.fantasybooks.hu/"),
                new Link("Lidércfény Online", "http://www.lidercfeny.hu/"),
                new Link("Történelem", "http://www.tortenelem.eu/")
            };

            return links;
        }
    }
}