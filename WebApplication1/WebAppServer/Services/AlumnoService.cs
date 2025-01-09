using WebAppServer.Models;

namespace WebAppServer.Services
{
    //Creamos una clase donde esta la logica del negocio en este caso la logica es sencilla ya que se quiere testear el sistema. 
    public class AlumnoService
    {
        List<Alumno> alumnos = new List<Alumno>()//Creamos una lista harcodeada de alumnos.
        {
            new Alumno(){Nombre = "Juan",Id = 1,Nota = 10,LU = 100},
            new Alumno(){Nombre = "Julian",Id = 2,Nota = 5,LU = 101},
            new Alumno(){Nombre = "Juana",Id = 3,Nota = 8,LU = 102},
            new Alumno(){Nombre = "Julio",Id = 4,Nota = 9.5,LU = 103}
        };

        public List<Alumno> GetAll()//Este metodo nos devuelve la lista ordenada por nota.
        {
            return alumnos.OrderBy(a => a.LU).ToList();//Exprecion Lambda.
        }
        public Alumno GetById(int id)//Nos devuelve un alumno especifico, lo busca por la LU
        {
            var a = alumnos.Where(a2 => a2.Id == id).FirstOrDefault();//Exprecion Lambda.
            if (a != null) return a;
            return null;
        }
        public bool Insert(Alumno a)//Inserta un alumno a la lista.
        {
            if(a != null)
            {
                alumnos.Add(a);
                return true;
            }
            return false;
        }
        public bool Update(int id, Alumno a)//Actualiza los datos de un alumno, menos el ID.
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
        public bool Delete(int id)//Borra un alumno de la lista.
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
