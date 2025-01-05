namespace WebApplication1.Models
{
    public class Alumno: IComparable
    {
        public string Nom {  get; set; }
        public long LU { get; set; }
        public int Id { get; set; }
        public double Nota { get; set; }

        public int CompareTo(object obj)
        {
            Alumno a = obj as Alumno;
            if (a != null) return a.Id.CompareTo(Id);
            else return 1;
        }
    }
}
