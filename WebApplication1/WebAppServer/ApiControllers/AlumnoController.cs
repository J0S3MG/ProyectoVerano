using Microsoft.AspNetCore.Mvc;
using WebAppServer.Models;
using WebAppServer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppServer.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        static AlumnoService servicio = new AlumnoService();

        [HttpGet]
        public IActionResult GetListaAlumno()
        {
            var la = servicio.GetAll();
            if (la != null)
            {
                return Ok(la);
            }
            return NotFound("La Lista no Existe");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var a = servicio.GetById(id);
            if (a != null)
            {
                return Ok(a);
            }
            return NotFound("El Alumno no Existe");
        }

        [HttpPost]
        public IActionResult PostAgregarAlumno([FromBody] Alumno a)
        {
            var b = servicio.Insert(a);
            if (b == true)
            {
                return Ok("Alumno Agregado Correctamente");
            }
            return BadRequest("Fallo el Proceso");
        }

        [HttpPut("{id}")]
        public IActionResult PutModificarAlumno(int id, [FromBody] Alumno a)
        {
            var b = servicio.Update(id, a);
            if (b == true)
            {
                return Ok("Alumno Modificado Correctamente");
            }
            return BadRequest("Fallo el Proceso");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAlumno(int id)
        {
            var b = servicio.Delete(id);
            if (b == true)
            {
                return Ok("Alumno Borrado Correctamente");
            }
            return BadRequest("Fallo el Proceso");
        }
    }
}
