using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        [Required (ErrorMessage = "Campo obligatorio")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Password { get; set; }
    }
}
