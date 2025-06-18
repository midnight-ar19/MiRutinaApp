namespace MiRutina.Models
{
    public class RutinaEjercicio
    {
        public int Id { get; set; }
        public int RutinaId { get; set; }
        public Rutina Rutina { get; set; }
        public int EjercicioId { get; set; }
        public Ejercicio Ejercicio { get; set; }
        public int Series { get; set; }
        public int Repeticiones { get; set; }
    }
}
