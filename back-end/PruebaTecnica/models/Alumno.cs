namespace PruebaTecnica.models
{
    public class Alumno
    {

        public int Id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNacimineto { get; set; }
        public string nombrePadre { get; set; }
        public string nombreMadre { get; set; }
        public int grado { get; set; }
        public string seccion { get; set; }
        public DateTime fechaInscripcion { get; set; }
    }
}
