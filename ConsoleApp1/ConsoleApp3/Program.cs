using Microsoft.Data.SqlClient;
using System.Data;

var personaNombre = "Juana";
var personaLU = 103;
var personaNota = 2;
var cadenaConexion = "workstation id=PruebaAlumnosDB.mssql.somee.com;packet size=4096;user id=J0S3MG_SQLLogin_2;pwd=jjj68abtub;data source=PruebaAlumnosDB.mssql.somee.com;persist security info=False;initial catalog=PruebaAlumnosDB;TrustServerCertificate=True";

var query = "INSERT INTO Alumnos (Nombre,LU,Nota)  OUTPUT INSERTED.ID Values (@Nombre1,@LU,@Nota)";

using var conexion = new SqlConnection(cadenaConexion);
conexion.Open();

using var comando = new SqlCommand(query, conexion);
comando.Parameters.AddWithValue("@Nombre1", personaNombre);
comando.Parameters.AddWithValue("@LU", personaLU);
comando.Parameters.AddWithValue("@Nota", personaNota);

var cantidad = comando.ExecuteNonQuery();

Console.WriteLine(cantidad);//Devuelve la cantidad

var newId = comando.ExecuteScalar();//devuelve el id.

Console.WriteLine(newId);