using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }
        [StringLength(200, ErrorMessage ="La descripción debe tener maximo 200 caracteres")]
        [Required(ErrorMessage ="La descripción es obligatoria")]
        [Display(Name ="Descripción", Prompt ="Ingrese una descripción")]
        public string Description { get; set; }
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
    }
}
