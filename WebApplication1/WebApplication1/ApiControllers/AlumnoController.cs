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
        
        [HttpGet]
        public IActionResult GetAlumnos()
        {
            return Ok(servicio.GetAlumnos());
        }

       
        [HttpGet("Mostrar Alumno {id}")]
        public IActionResult GetAlumno(int id)
        {
            Alumno a = servicio.Busq(id);
            if (a != null)
            {
                return Ok(a);
            }
            return NotFound("El alumno no existe");
        }

      
        [HttpPost("Agregar Alumno {value}")]
        public IActionResult PostAgregarAlumno([FromBody] Alumno value)
        {
            bool add = servicio.AddAlumno(value);
            if (add)
            {
                return Ok("Alumno agregado correctamente");
            }
            return BadRequest("Error al cargar el alumno");
        }

       
        [HttpPut("Modificar Alumno {id} {value}")]
        public IActionResult PutAlumno(int id, [FromBody] Alumno value)
        {
            bool act = servicio.ModAlumno(id, value);
            if (act == true)
            {
                return Ok("Se modifico correctamente");
            }
            return NotFound("No se puede modificar");
        }

        
        [HttpDelete("Borrar Alumno {id}")]
        public IActionResult DeleteAlumno(int id)
        {
            bool remove = servicio.DeleteAlumno(id);
            Alumno a = servicio.Busq(id);
            if (remove == true)
            {
                return Ok("Alumno borrado:");
            }
            return NotFound("Alumno no encontrado");
        }
    }
}
