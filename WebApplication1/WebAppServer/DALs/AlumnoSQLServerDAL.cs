using Microsoft.Data.SqlClient;
using WebAppServer.Models;

namespace WebAppServer.DALs
{
    //Creamos una clase que se va encargar de la conexion a la base de datos.
    public class AlumnoSQLServerDAL
    {
        private readonly string connectionString;//Creamos un atributo el cual guardara la conexion a la base de datos.

        public AlumnoSQLServerDAL(string conexion)//En este constructor le pasamos la conexion que la establece AlumnoService.
        {
            connectionString = conexion;
        }

        public List<Alumno> GetAll()//Creamos un metodo GetAll que nos devuelve la lista. 
        {
            var lista = new List<Alumno>();//Creamos la lista a retornar.
            //El using hace que se cierre.
            using var conexion = new SqlConnection(connectionString);//Conexion a la base.
            conexion.Open();//Abrimos la base de datos.

            var query = "SELECT * FROM Alumnos";//Ceramos la consulta.

            using var comando = new SqlCommand(query, conexion);//Le pasamos la consulta y la conexion al comando.
            var reader = comando.ExecuteReader();//Nos devuelve las filas de la tabla. Cada fila es una suerte de Vector.

            while (reader.Read())//Aca se mueve a la siguiente fila. 
            {//Agregamos un nuevo alumno a la lista. Con cada uno de los Get obtenemos el valor en la posicion indicada.
                lista.Add(new Alumno() {Id = reader.GetInt32(0), Nombre = reader.GetString(1),//Cada Columna es una posicion en el Vector.
                                       LU = reader.GetInt32(2),Nota = reader.GetDecimal(3)});
            }
            return lista.OrderBy(a => a.LU).ToList();//Exprecion Lambda.
        }
    }
}
