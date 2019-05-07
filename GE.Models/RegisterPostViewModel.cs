using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GE.Models
{
    public class RegisterPostViewModel
    {
        [Required]
        [Display(Name = "Имя")]
        [StringLength(30, ErrorMessage = "Значение {0} должно содержать не менее {2} символов и не более {1}.", MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        [StringLength(200, ErrorMessage = "Значение {0} должно содержать не менее {2} символов и не более {1}.", MinimumLength = 5)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Подкатегория")]
        public string Subcategory { get; set; }

        [Required]
        [Display(Name = "Город")]
        public string City { get; set; }
    }
}