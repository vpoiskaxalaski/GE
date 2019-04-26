using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace diplom.Models
{
    public class RegisterModeratorViewModel
    {
        [Required]
        [Display(Name = "Имя")]
        [StringLength(30, ErrorMessage = "Значение {0} должно содержать не менее {2} символов и не более {1}.", MinimumLength = 3)]
        public string Name { get; set; }
    }
}