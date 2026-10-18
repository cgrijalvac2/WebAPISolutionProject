using System.ComponentModel.DataAnnotations;

namespace WebAPISolution.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Apellidos { get; set; }

    }
}
