using Microsoft.AspNetCore.Mvc;
using WebAppServer.Models;
using WebAppServer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppServer.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase //Creo un controlador que va a manejar los Response.
    {
        static AlumnoService servicio = new AlumnoService();//Creo una instancia de AlumnoService.

        [HttpGet]//Utilizo el IActionResult para poder usar los codigos de estado.
        public IActionResult GetAll()
        {
            var la = servicio.GetAll();//Llamo al metodo GetAll.
            if (la != null)//Si devuelve distinto de null.
            {
                return Ok(la);//Lanza un 200.
            }//Sino lanza un 404.
            return NotFound("La Lista no Existe");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var a = servicio.GetById(id);
            if (a != null)//Si devuelve distinto de null.
            {
                return Ok(a);//Lanza un 200.
            }//Sino lanza un 404.
            return NotFound("El Alumno no Existe");
        }

        [HttpPost]
        public IActionResult PostInsert([FromBody] Alumno a)
        {
            var b = servicio.Insert(a);
            if (b == true)//Si devuelve true.
            {
                return Ok("Alumno Agregado Correctamente");//Lanza un 200.
            }//Sino lanza un 400.
            return BadRequest("Fallo el Proceso");
        }

        [HttpPut("{id}")]
        public IActionResult PutUpdate(int id, [FromBody] Alumno a)
        {
            var b = servicio.Update(id, a);
            if (b == true)//Si devuelve true.
            {
                return Ok("Alumno Modificado Correctamente");//Lanza un 200.
            }//Sino lanza un 400.
            return BadRequest("Fallo el Proceso");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var b = servicio.Delete(id);
            if (b == true)//Si devuelve true.
            {
                return Ok("Alumno Borrado Correctamente");//Lanza un 200.
            }//Sino lanza un 400.
            return BadRequest("Fallo el Proceso");
        }
    }
}
