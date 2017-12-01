using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.Models
{
    public class LinkSuggestion
    {
        [Display(Name = "A link neve")]
        [Required(ErrorMessage = "Kérem, adja meg a link szövegét!")]
        [StringLength(80)]
        public string LinkName { get; set; }

        [Display(Name = "A link URL-je")]
        [Required(ErrorMessage = "Kérem, adja meg az URL-t!")]
        [StringLength(80)]
        [Url]
        public string URL { get; set; }

        [Display(Name = "Megjegyzés")]
        [StringLength(255)]
        public string Remark { get; set; }
    }
}