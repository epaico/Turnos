using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage ="La direccion es obligatoria")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "EL telefono es obligatorio")]
        [Phone(ErrorMessage ="Formato no valido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "No es un email")]
        public string Email { get; set; }

        public List<Turno> Turno { get; set; }
    }
}
