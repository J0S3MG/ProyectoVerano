using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AlumnoService
    {
        List<Alumno> alumnos = new List<Alumno>() 
        {
            new Alumno(){Nom = "Juan", LU = 120, Id = 100, Nota = 9.5},
            new Alumno(){Nom = "Alexis", LU = 129, Id = 101, Nota = 9},
            new Alumno(){Nom = "Ivan", LU = 128, Id = 102, Nota = 8},
            new Alumno(){Nom = "Ulises", LU = 127, Id = 103, Nota = 6},
            new Alumno(){Nom = "Laura", LU = 126, Id = 104, Nota = 10}
        };

        public IEnumerable<Alumno> GetAll()
        {
            return alumnos.OrderBy(p => p.Id).ToList();
        }
        public Alumno Busq(int id)
        {
            /*alumnos.Sort();
            Alumno alumno = new Alumno();
            alumno.Id = id;
            int idx = alumnos.BinarySearch(alumno);
            if(idx >= 0) return alumnos[idx];
            return null;*/
            var alumno = alumnos.Where(a => a.Id == id).FirstOrDefault();
            return alumno;
        }
    }
}
