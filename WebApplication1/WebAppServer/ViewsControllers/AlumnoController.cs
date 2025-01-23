using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppServer.Controllers;
using WebAppServer.Models;
using WebAppServer.Services;

namespace WebAppServer.ViewsControllers
{
    public class AlumnoController : Controller
    {
        #region Sin Persistencia.
        List<Alumno> alumnos = new List<Alumno>()//Creamos una lista harcodeada de alumnos.
        {
            new Alumno(){Nombre = "Juan",Id = 1,Nota = 10,LU = 100},
            new Alumno(){Nombre = "Julian",Id = 2,Nota = 5,LU = 101},
            new Alumno(){Nombre = "Juana",Id = 3,Nota = 8,LU = 102},
            new Alumno(){Nombre = "Julio",Id = 4,Nota = 9.5m,LU = 103}
        };
        #endregion 
        static AlumnoService servicio = new AlumnoService();
        public ActionResult Layout()
        {
            return View();
        }
        #region Caso GetAll.
        // GET: AlumnoController
        public ActionResult GetAll()//Parecido al metodo del RestAPI pero devuelve un HTML.
        {
            return View(servicio.GetAll());//Trae el HTML con el codigo cargado.
        }
        #endregion
        /*/ GET: AlumnoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }*/
        #region Caso Insert
        // GET: AlumnoController/Create
        public ActionResult Insert()
        {
            return View();
        }

        // POST: AlumnoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(Alumno a)
        {
            try
            {
                servicio.Insert(a);
                return RedirectToAction(nameof(Layout));
            }
            catch
            {
                return View();
            }
        }
        #endregion
        /*/ GET: AlumnoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlumnoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlumnoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
