using JN_WEB.Entities;
using JN_WEB.Interfaces;
using JN_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace JN_WEB.Controllers
{
    public class CarritoController : Controller
    {
        private readonly ICarritoModel _carritoModel;

        public CarritoController(ICarritoModel carritoModel)
        {
            _carritoModel = carritoModel;
        }

        [HttpGet]
        public IActionResult AgregarCursoCarrito(long q)
        {
            CarritoEnt entidad = new CarritoEnt();
            entidad.IdCurso = q;

            _carritoModel.AgregarCursoCarrito(entidad);
            var datosCarrito = _carritoModel.ConsultarResumenCarrito();

            HttpContext.Session.SetString("Cantidad", datosCarrito?.Objeto.Cantidad.ToString());
            HttpContext.Session.SetString("SubTotal", datosCarrito?.Objeto.SubTotal.ToString());

            return RedirectToAction("PantallaPrincipal", "Home");
        }
    }
}
