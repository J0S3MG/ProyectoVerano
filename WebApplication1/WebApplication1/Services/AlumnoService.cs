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

        public List<Alumno> GetAlumnos()
        {
            return alumnos.OrderBy(p => p.Id).ToList();
        }
        public Alumno Busq(int id)
        {
            var alumno = alumnos.Where(a => a.Id == id).FirstOrDefault();
            if (alumno != null) return alumno;
            else return null;
        }
        public bool AddAlumno(Alumno alumno)
        {
            if (alumno != null)
            {
                alumnos.Add(alumno);
                return true;
            }
            return false;
        }
        public bool ModAlumno(int id, Alumno a)
        {
            Alumno a2 = Busq(id);
            if (a2 != null)
            {
                a2.Actualizar(a);
                return true;
            }
            return false;
        }
        public bool DeleteAlumno(int id)
        {
            var alumno = Busq(id);
            if (alumnos.Remove(alumno))
            {
                return true;
            }
            return false;
        }
    }
}
