namespace WebApplication1.Models
{
    public class Alumno
    {
        public string Nom { get; set; }
        public long LU { get; set; }
        public int Id { get; set; }
        public double Nota { get; set; }

        public void Actualizar(Alumno a)
        {
            Nom = a.Nom;
            LU = a.LU;
            Nota = a.Nota;
        }
    }
}
