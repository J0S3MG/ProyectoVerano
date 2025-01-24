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
        #region Caso GetAll.
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
        #endregion
        #region Caso GetById.
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
        #endregion
        #region Caso Insert.
        [HttpPost]
        public IActionResult PostInsert([FromBody] Alumno a)
        {
            var a2 = servicio.Insert(a);
            if (a2 != null)//Si devuelve true.
            {
                return Ok(a2);//Lanza un 200.
            }//Sino lanza un 400.
            return BadRequest(new { msj = "Fallo el Proceso" });
        }
        #endregion
        #region Caso Update.
        [HttpPut]
        public IActionResult PutUpdate([FromBody] Alumno a)
        {
            if (servicio.Update(a) == false)
            {
                return NotFound(new { Message = "Alumno no encontrado" });
            }
            return Ok(a);
        }
        #endregion
        #region Caso Delete.
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (servicio.Delete(id) == false)
            {
                return NotFound(new { Message = "Alumno no encontrado" });
            }
            return NoContent();//204
           
        }
        #endregion
    }
}
