using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsCliente.Models
{
    //Creamos una clase que va a recivir los datos del Json. No hace falta que la clase se llame igual solo que los datos coincidan.
    public class Alumno 
    {   
        //Los Json funcionan con pares clave-valor.

        [JsonPropertyName("nombre")]//Con esta etiqueta indicamos la propiedad a la que pertenece esta clave.
        public string Nombre { get; set; }

        [JsonPropertyName("id")]//Con esta etiqueta indicamos la propiedad a la que pertenece esta clave.
        public int Id { get; set; }

        [JsonPropertyName("nota")]//Con esta etiqueta indicamos la propiedad a la que pertenece esta clave.
        public decimal Nota { get; set; }

        [JsonPropertyName("lu")]//Con esta etiqueta indicamos la propiedad a la que pertenece esta clave.
        public int LU { get; set; }

        public Alumno() { }
        public Alumno(int LU,decimal nota, string nom)
        {
            this.LU = LU;
            this.Nota = nota;
            Nombre = nom;
        }
    }
}
