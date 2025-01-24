using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppServer.Controllers;
using WebAppServer.Models;
using WebAppServer.Services;

namespace WebAppServer.ViewsControllers
{
    public class AlumnoController : Controller
    {
        static AlumnoService servicio = new AlumnoService();
        public ActionResult Layout()
        {
            return View();
        }
        #region Caso GetAll.
        // GET: AlumnoController
        public ActionResult Index()//Parecido al metodo del RestAPI pero devuelve un HTML.
        {
            return View(servicio.GetAll());//Trae el HTML con el codigo cargado.
        }
        #endregion
        #region Caso GetById.
        // GET: AlumnoController/Details/5
        public ActionResult Details(int id)
        {
            return View(servicio.GetById(id));
        }
        #endregion
        #region Caso Insert.
        // GET: AlumnoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlumnoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alumno a)
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
        #region Caso Update.
        // GET: AlumnoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(servicio.GetById(id));
        }

        // POST: AlumnoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Alumno a)
        {
            try
            {
                servicio.Update(a);
                return RedirectToAction(nameof(Layout));
            }
            catch
            {
                return View();
            }
        }
        #endregion
        #region Caso Delete.
        // GET: AlumnoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(servicio.GetById(id));
        }

        // POST: AlumnoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Alumno a)
        {
            try
            {
                servicio.Delete(a.Id);
                return RedirectToAction(nameof(Layout));
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
