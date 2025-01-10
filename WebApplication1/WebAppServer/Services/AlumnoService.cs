using WebAppServer.DALs;
using WebAppServer.Models;

namespace WebAppServer.Services
{
    //Creamos una clase donde esta la logica del negocio en este caso la logica es sencilla ya que se quiere testear el sistema. 
    public class AlumnoService
    {
        #region Sin Persistencia.
        List<Alumno> alumnos = new List<Alumno>()//Creamos una lista harcodeada de alumnos.
        {
            new Alumno(){Nombre = "Juan",Id = 1,Nota = 10,LU = 100},
            new Alumno(){Nombre = "Julian",Id = 2,Nota = 5,LU = 101},
            new Alumno(){Nombre = "Juana",Id = 3,Nota = 8,LU = 102},
            new Alumno(){Nombre = "Julio",Id = 4,Nota = 9.5m,LU = 103}
        };
        #endregion 
        //Conexion con el servidor SQL.
        string conexionSQL = "workstation id=PruebaAlumnosDB.mssql.somee.com;packet size=4096;user id=J0S3MG_SQLLogin_2;pwd=jjj68abtub;data source=PruebaAlumnosDB.mssql.somee.com;persist security info=False;initial catalog=PruebaAlumnosDB;TrustServerCertificate=True";
        AlumnoSQLServerDAL alumnoDAO;
        public AlumnoService()
        {
             alumnoDAO = new AlumnoSQLServerDAL(conexionSQL);
        }
        public List<Alumno> GetAll()//Este metodo nos devuelve la lista ordenada por nota.
        {
            return alumnoDAO.GetAll();
        }
        public Alumno GetById(int id)//Nos devuelve un alumno especifico, lo busca por la LU
        {
            var a = alumnos.Where(a2 => a2.Id == id).FirstOrDefault();//Exprecion Lambda.
            if (a != null) return a;
            return null;
        }
        public Alumno Insert(Alumno a)//Inserta un alumno a la lista.
        {
            if(a != null)
            {
                alumnos.Add(a);
                return a;
            }
            return null;
        }
        public Alumno Update(Alumno a)//Actualiza los datos de un alumno, menos el ID.
        {
            var a2 = GetById(a.Id);
            if (a2 != null)
            {
                a2.Nombre = a.Nombre;
                a2.Nota = a.Nota;
                a2.LU = a.LU;
                return a2;
            }
            return null;
        }
        public Alumno Delete(int id)//Borra un alumno de la lista.
        {
            var a = GetById(id);
            if (a != null)
            {
                alumnos.Remove(a);
                return a;
            }
            return null;
        }
    }
}
