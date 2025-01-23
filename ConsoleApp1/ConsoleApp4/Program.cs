using Microsoft.Data.SqlClient;
using System.Data;


var Nombre = "Jaime";
var id = 1;

var cadenaConexion = "workstation id=PruebaAlumnosDB.mssql.somee.com;packet size=4096;user id=J0S3MG_SQLLogin_2;pwd=jjj68abtub;data source=PruebaAlumnosDB.mssql.somee.com;persist security info=False;initial catalog=PruebaAlumnosDB;TrustServerCertificate=True";
var query = "UPDATE Alumnos SET Nombre = @Nombre WHERE Id = @Id";

using var conexion = new SqlConnection(cadenaConexion);//Conexion a la base
conexion.Open();
using var comando = new SqlCommand(query, conexion);

comando.Parameters.AddWithValue("@Nombre", Nombre);
comando.Parameters.AddWithValue("@Id", id);

var newId = comando.ExecuteNonQuery();

Console.WriteLine(newId);