using MyAspNETWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.DAL
{
    public class ProgLinksData
    {
        public List<Link> GetLinks()
        {
            List<Link> links = new List<Link>
            {
                new Link("cplusplus.com", "http://www.cplusplus.com/"),
                new Link("InfoC portál", "https://infoc.eet.bme.hu/"),
                new Link("Prog.hu", "https://prog.hu/"),
                new Link("Marco Cantu Delphi oldala", "http://www.marcocantu.com/"),
                new Link("ELTE programozási nyelvek portál", "http://nyelvek.inf.elte.hu/"),
                new Link("Játékfejlesztés.hu", "http://jatekfejlesztes.hu/")
            };

            return links;
        }
    }
}
