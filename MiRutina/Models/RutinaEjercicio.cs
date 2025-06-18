using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiRutina.Models
{
    public class RutinaEjercicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RutinaId { get; set; }
        public Rutina Rutina { get; set; }
        public int EjercicioId { get; set; }
        public Ejercicio Ejercicio { get; set; }
        public int Series { get; set; }
        public int Repeticiones { get; set; }
    }
}
