using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyAspNETWebsite.Models
{
    public class PrivateMessage
    {
        [Display(Name = "A tárgy")]
        [Required(ErrorMessage = "Kérem, adja meg az üzenet tárgyát!")]
        [StringLength(80)]
        public string Subject { get; set; }

        [Display(Name = "Az üzenet szövege")]
        [Required(ErrorMessage = "Kérem, adja meg az üzenet szövegét!")]
        [StringLength(255)]
        public string MessageText { get; set; }
    }
}
