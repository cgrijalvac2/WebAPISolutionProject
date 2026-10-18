using System.ComponentModel.DataAnnotations;

namespace WebAPISolution.Models
{
    public class Asignacion
    {
        [Key]
        public int AsignacionId { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int CursoId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int DocenteId { get; set; }

        public Estudiante? Estudiante { get; set; }
        public Curso? Curso { get; set; }
        public Docente? Docente { get; set; }
    }
}
