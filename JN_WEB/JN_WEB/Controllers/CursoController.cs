using Microsoft.AspNetCore.Mvc;

namespace JN_WEB.Controllers
{
    public class CursoController : Controller
    {
        [HttpGet]
        public IActionResult ConsultarCursosUsuario()
        {
            return View();
        }
    }
}
