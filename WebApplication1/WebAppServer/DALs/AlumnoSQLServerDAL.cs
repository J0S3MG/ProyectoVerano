using Microsoft.Data.SqlClient;
using System.Data;
using WebAppServer.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        #region Caso GetAll.
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
                lista.Add(new Alumno()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),//Cada Columna es una posicion en el Vector.
                    LU = reader.GetInt32(2),
                    Nota = reader.GetDecimal(3)
                });
            }
            return lista.OrderBy(a => a.LU).ToList();//Exprecion Lambda.
        }
        #endregion
        #region Caso GetById.
        public Alumno? GetById(int id)//Creamos un metodo que nos devuelve un Alumno. 
        {
            Alumno a = null;//Creamos el alumno a retornar.
            //El using hace que se cierre.
            using var conexion = new SqlConnection(connectionString);//Conexion a la base.
            conexion.Open();//Abrimos la base de datos.

            var query = "SELECT * FROM Alumnos WHERE Id = @Id";//Ceramos la consulta.

            using var comando = new SqlCommand(query, conexion);//Le pasamos la consulta y la conexion al comando.
            comando.Parameters.AddWithValue("@Id", id);//Le pasamos el par Clave-Valor con el valor a buscar.

            var reader = comando.ExecuteReader();//Nos devuelve la fila con el alumno que estamos buscando.

            if (reader.Read())//Si hay algo para leer, quiere decir que el Alumno existe. Lo reconstruimos en un obj.
            {
                a = new Alumno() { Id = reader.GetInt32(0), Nombre = reader.GetString(1), LU = reader.GetInt32(2), Nota = reader.GetDecimal(3) };
            }
            return a;
        }
        #endregion
        #region Caso Insert.
        public Alumno? Insert(Alumno a)//Creamos un metodo que agrega en la base de datos un Alumno.
        {
            using var conexion = new SqlConnection(connectionString);//Nos conectamos a la base.
            conexion.Open();//La abrimos.
            //Creamos la consulta en este caso al agregar a la tabla nos devuelve el id.
            var query = "INSERT INTO Alumnos (Nombre,LU,Nota)  OUTPUT INSERTED.ID Values (@Nombre1,@LU,@Nota)";

            using var comando = new SqlCommand(query, conexion);//Creamos el comando.
            comando.Parameters.AddWithValue("@Nombre1", a.Nombre);//Añadimos los datos a la tabla.
            comando.Parameters.AddWithValue("@LU", a.LU);//Añadimos los datos a la tabla.
            comando.Parameters.AddWithValue("@Nota", a.Nota);//Añadimos los datos a la tabla.

            var newId = comando.ExecuteScalar();//devuelve el id.
            var a2 = GetById((int)newId);//Buscamos el Alumno añadido recientemente.
            return a2;//Lo retornamos 
        }
        #endregion
        #region Caso Update.
        public bool Update(Alumno a)//Actualiza los datos de un alumno, menos el ID.
        {
            using var conexion = new SqlConnection(connectionString);//Conexion a la base
            conexion.Open();

            var query = "UPDATE Alumnos SET Nombre = @Nombre, LU = @LU,Nota = @Nota WHERE Id = @Id";
            using var comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@Nombre", a.Nombre);
            comando.Parameters.AddWithValue("@LU", a.LU);
            comando.Parameters.AddWithValue("@Nota", a.Nota);
            comando.Parameters.AddWithValue("@Id", a.Id);
            comando.ExecuteNonQuery();
            return true;
        }
        #endregion
        #region Caso Delete.
        public bool Delete(int id)//Borra un alumno de la lista.
        {
            using var conexion = new SqlConnection(connectionString);//Conexion a la base
            conexion.Open();
            var query = "DELETE  FROM Alumnos WHERE Id = @ID";
            using var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            return true;
        }
        #endregion
    }
}
