using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        static AlumnoService servicio = new AlumnoService();
        // GET: api/<AlumnoController>
        [HttpGet("Mostrar Lista de Alumnos")]
        public IActionResult GetAlumnos()
        {
            return Ok(servicio.GetAll());
        }

        // GET api/<AlumnoController>/5
        [HttpGet("Mostrar Alumno")]
        public IActionResult GetAlumnoById(int id)
        {
            Alumno a = servicio.Busq(id);
            return Ok(a);
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
