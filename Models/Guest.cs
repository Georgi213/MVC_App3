using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class Guest
    {
        public int Id;
        [Required(ErrorMessage = "On vaja sisesta oma nime!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "On vaja sisatada email!!!")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Viga emaili sisestamiseks!!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sisesta oma telefoni number!!!")]
        [RegularExpression(@"\+372.+", ErrorMessage = "Vale telefoni number, Alguses on +372...")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Tee oma valik!!!")]
        public bool? WillAttend { get; set; }
    }
}