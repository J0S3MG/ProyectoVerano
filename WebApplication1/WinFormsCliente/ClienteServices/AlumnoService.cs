using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsCliente.Models;

namespace WinFormsCliente.ClienteServices
{
    public class AlumnoService
    {
        async public Task<List<Alumno>> GetAll()
        {
            List<Alumno> lista = new List<Alumno>();
            string url = "http://localhost:8080/api/Alumno";

            var Cliente = new HttpClient();

            var response = await Cliente.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                lista = System.Text.Json.JsonSerializer.Deserialize<List<Alumno>>(json);
            }
            return lista;
        }
    }
}
