using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

        [Required(ErrorMessage ="El campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Apellido { get; set; }

        [Display(Name ="Dirección")]
        [Required(ErrorMessage ="El campo es obligatorio")]
        public string Direccion { get; set; }

        [Display(Name ="Teléfono")]
        [Required(ErrorMessage ="El campo es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage ="El campo es obligatorio")]
        [EmailAddress(ErrorMessage = "No es una direccion correcta")]
        public string Email { get; set; }

        [Display(Name = "Horario desde")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString ="{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionDesde { get; set; }

        [Display(Name = "Horario desde")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode =true)]
        public DateTime HorarioAtencionHasta { get; set; }

        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }

        public List<Turno> Turno { get; set; }

    }
}
