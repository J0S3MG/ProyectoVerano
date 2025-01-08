using WebAppServer.Models;

namespace WebAppServer.Services
{
    public class AlumnoService
    {
        List<Alumno> alumnos = new List<Alumno>()
        {
            new Alumno(){Nombre = "Juan",Id = 1,Nota = 10,LU = 100},
            new Alumno(){Nombre = "Julian",Id = 2,Nota = 10,LU = 101},
            new Alumno(){Nombre = "Juana",Id = 3,Nota = 10,LU = 102},
            new Alumno(){Nombre = "Julio",Id = 4,Nota = 10,LU = 103}
        };

        public List<Alumno> GetAll()
        {
            return alumnos.OrderBy(a => a.LU).ToList();//Exprecion Lambda.
        }
        public Alumno GetById(int id)
        {
            var a = alumnos.Where(a2 => a2.Id == id).FirstOrDefault();//Exprecion Lambda.
            if (a != null) return a;
            return null;
        }
        public bool Insert(Alumno a)
        {
            if(a != null)
            {
                alumnos.Add(a);
                return true;
            }
            return false;
        }
        public bool Update(int id, Alumno a)
        {
            var a2 = GetById(id);
            if (a2 != null)
            {
                a2.Nombre = a.Nombre;
                a2.Nota = a.Nota;
                a2.LU = a.LU;
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            var a = GetById(id);
            if (a != null)
            {
                alumnos.Remove(a);
                return true;
            }
            return false;
        }
    }
}
