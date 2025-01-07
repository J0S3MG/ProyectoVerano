using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsCliente.Models
{
    public class Alumno
    {
        [JsonPropertyName("nom")]
        public string Nom { get; set; }

        [JsonPropertyName("lu")]
        public long LU { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nota")]
        public double Nota { get; set; }
    }
}
