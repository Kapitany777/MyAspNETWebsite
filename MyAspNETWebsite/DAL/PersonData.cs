using MyAspNETWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.DAL
{
    public class PersonData
    {
        public Person GetPersonData()
        {
            Person person = new Person
            {
                Name = "Török Viktor",
                BirthDate = 1972,
                Profession = "programozó",
                City = "Szentes",
                HomePage = "http://www.braincluster.eu/",
                LinkedinProfile = "https://www.linkedin.com/in/viktor-t%C3%B6r%C3%B6k-65b7a067/",

                Qualifications = new List<Qualification>
                {
                    new Qualification("Eötvös Loránd Tudományegyetem TTK", "programozó matematikus"),
                    new Qualification("Szegedi Tudományegyetem GTK", "közgazdasági szakokleveles programozó matematikus"),
                    new Qualification("Kecskeméti Főiskola, GAMF", "mérnökinformatikus rendszergazda")
                }
            };

            return person;
        }
    }
}