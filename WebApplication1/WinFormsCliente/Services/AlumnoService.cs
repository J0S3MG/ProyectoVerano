using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WinFormsCliente.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

                lista = JsonSerializer.Deserialize<List<Alumno>>(json);//Deserealizamos el Json y lo volvemos un objeto nuevamente.
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

                a = JsonSerializer.Deserialize<Alumno>(json);//Deserealizamos el Json y lo volvemos un objeto nuevamente.
            }
            return a;//Retornamos el alumno.
        }
        #endregion
        #region Caso Delete.
        public async Task<Alumno> Delete(int id)//El Delete tiene una estructura similar al caso anterior.
        {
            Alumno a = new Alumno();
            string url = "http://localhost:5038/api/Alumno";

            var Cliente = new HttpClient();
            var response = await Cliente.DeleteAsync($"{url}/{id}");//Aca en vez de utilizar el metodo GetAsync usamos el DeleteAsync.

            if(response.IsSuccessStatusCode)//Chequeamos el codigo de estado de la respuesta.
            {
                string json = await response.Content.ReadAsStringAsync();//Extraemos el Json.
                a = JsonSerializer.Deserialize<Alumno>(json);//Deserealizamos el Json.
            }
            return a;//Retornamos el alumno eliminado.
        }
        #endregion
        #region Caso PostInsert.
        public async Task<Alumno> Insert(int id, int LU, decimal nota,string nombre)//Le pasamos los datos del nuevo alumno.
        {
            Alumno a2 = new Alumno();//Creamos la variable que recibira el Json.
            Alumno a = new Alumno(LU,nota,nombre);//Creamos el nuevo alumno.
            a.Id = id;//Le asignamos el ID.

            string url = "http://localhost:5038/api/Alumno";//Obtenemos la URL de la Request por medio del swagger.
            var Cliente = new HttpClient();//Creamos el cliente el cual nos va a ayudar a tratar la Request.

            string Json = JsonSerializer.Serialize(a);//Serealizamos al alumno que queremos agregar y lo transformamos en un Json.
            HttpContent cont = new StringContent(Json,Encoding.UTF8,"application/json");//Creamos el contenido de la Request.

            var response = await Cliente.PostAsync(url,cont);//Invocamos al metodo PostAsync y le pasamos la url + el contenido.

            if(response.IsSuccessStatusCode)//Chequeamos el codigo de estado del Response.
            {
                string json = await response.Content.ReadAsStringAsync();//Extraemos el Json.
                a2 = JsonSerializer.Deserialize<Alumno>(json);//Deserealizamos el Json.
            }
            return a2;

        }
        #endregion
        #region Caso PutUpdate.
        public async Task<Alumno> Update(int id, int lu, decimal nota, string nombre)//Le pasamos los datos del alumno modificado.
        {
            Alumno a2 = new Alumno();//Creamos la variable que recibira el Json.
            Alumno a = new Alumno(lu, nota, nombre);//Creamos el obj modificado.
            a.Id = id;

            string url = "http://localhost:5038/api/Alumno";
            var Cliente = new HttpClient();

            string Json = JsonSerializer.Serialize(a);//Serealizamos el obj modificado.
            HttpContent cont = new StringContent(Json, Encoding.UTF8, "application/json");//Creamos el contenido de la Request.

            var response = await Cliente.PutAsync(url, cont);//Utilizamos el PutAsync para pasarle la url + el contenido.

            if (response.IsSuccessStatusCode)//Chequeamos el codigo de estado del Response.
            {
                string json = await response.Content.ReadAsStringAsync();//Extraemos el Json.
                a2 = JsonSerializer.Deserialize<Alumno>(json);//Deserealizamos el Json.
            }
            return a2;
        }
        #endregion

    }
}
