using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCliente.Models;

namespace WinFormsCliente.Services
{
    public class AlumnoService //Esta clase contendra la logica de las Request.
    {
        #region Caso GetAll.
        public async Task<List<Alumno>> GetAll()//Este es el metodo GetAll. Los metodos siempre se trabajan con el async, el task y el await.
        {
            List<Alumno> lista = new List<Alumno>();//Creamos la lista donde vamos a recibir los alumnos.

            string url = "http://localhost:5038/api/Alumno";//Obtenemos la URL de la Request por medio del swagger.

            var Cliente = new HttpClient();//Creamos el cliente el cual nos va a ayudar a tratar la Request.

            var response = await Cliente.GetAsync(url);//Obtenemos el Response.

            if (response.IsSuccessStatusCode)//Nos fijamos el estado del Response.
            {
                string json = await response.Content.ReadAsStringAsync();//Extraemos el Json.

                lista = System.Text.Json.JsonSerializer.Deserialize<List<Alumno>>(json);//Deserealizamos el Json y lo volvemos un objeto nuevamente.
            }
            return lista;//Retornamos la lista.
        }
        #endregion
        #region Caso GetById.
        public async Task<Alumno> GetById(int id)//Creo un metodo parecido al anterior.
        {
            Alumno a = new Alumno();//Creo el alumno donde se recive al alumno buscado.
            string url = "http://localhost:5038/api/Alumno";//Le paso la misma url que antes.

            var Cliente = new HttpClient();//Creamos el cliente el cual nos va a ayudar a tratar la Request.
            var response = await Cliente.GetAsync($"{url}/{id}");//Y aca le paso la url + el id que es el añadido.

            if (response.IsSuccessStatusCode)//Nos fijamos el estado del Response.
            {
                string json = await response.Content.ReadAsStringAsync();//Extraemos el Json.

                a = System.Text.Json.JsonSerializer.Deserialize<Alumno>(json);//Deserealizamos el Json y lo volvemos un objeto nuevamente.
            }
            return a;//Retornamos el alumno.
        }
        #endregion
        #region Caso Delete.
        /*public async Task<string> Delete(int id)
        {

        }*/
        #endregion
        #region Caso PostInsert.
        /*public async Task<string> Insert(int id, int LU, double nota,string nombre)
        {

        }*/
        #endregion
        #region Caso PutUpdate.
        /*public async Task<string> Update(int id, int LU, double nota, string nombr)
        {

        }*/
        #endregion

    }
}
