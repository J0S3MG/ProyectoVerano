using Microsoft.Data.SqlClient;
using System.Data;

var personaId = 4;

var cadenaConexion = "workstation id=PruebaAlumnosDB.mssql.somee.com;packet size=4096;user id=J0S3MG_SQLLogin_2;pwd=jjj68abtub;data source=PruebaAlumnosDB.mssql.somee.com;persist security info=False;initial catalog=PruebaAlumnosDB;TrustServerCertificate=True";

var query = "SELECT * FROM Alumnos WHERE ID=@ID;";

using var conexion = new SqlConnection(cadenaConexion);   //hace que se cierre
conexion.Open();

var comando = new SqlCommand(query, conexion);
comando.Parameters.AddWithValue("@ID", personaId);

//lleva adaptador por leer con select
var dt = new DataTable(query);
var adaptador = new SqlDataAdapter(comando);
adaptador.Fill(dt);


foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine($"{dr["id"]};{dr["nombre"]}");
}