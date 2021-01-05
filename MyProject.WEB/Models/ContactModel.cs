using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="İsim zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email zorunludur")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Başlık zorunludur")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Mesaj alanı zorunludur")]
        public string Message { get; set; }
    }
}
