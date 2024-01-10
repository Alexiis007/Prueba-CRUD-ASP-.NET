using Microsoft.AspNetCore.Mvc;
using EjercicioCRUD.Datos;
using EjercicioCRUD.Models;
namespace EjercicioCRUD.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        //Musetra de una lista de contactos
        public IActionResult Listar()
        {
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }
        //Muestra la vista 
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        //Metodo que permite recibir el objeto para guardarlo en la base de datos
        public IActionResult Guardar(ContactoModel oContacto)
        {
            //En caso de haber un error se retorna la vista para que se ingresen los datos de manera correcta
            if (!ModelState.IsValid)
            {
                return View();
            }
            //Una vez se paso el if anterior hacemos el proceso de guardar los datos y cargar la vista list
            var res = _ContactoDatos.Guardar(oContacto);
            if (res)
            { 
                return RedirectToAction("Listar");
            }
            return View();
        }
        public IActionResult Editar(int idContacto)
        {
            var oContacto = _ContactoDatos.obtener(idContacto);
            return View(oContacto);
        }
        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var res = _ContactoDatos.Editar(oContacto);
            if (res)
            {
                return RedirectToAction("Listar");
            }
            return View();
        }
        public IActionResult Eliminar(int idContacto)
        {
            var oContacto = _ContactoDatos.obtener(idContacto);
            return View(oContacto);
        }
        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
            var res = _ContactoDatos.Eliminar(oContacto.IdContacto);
            if (res)
            {
                return RedirectToAction("Listar");
            }
            return View();
        }


    }
}
