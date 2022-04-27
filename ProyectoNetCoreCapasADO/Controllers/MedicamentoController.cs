using Microsoft.AspNetCore.Mvc;

namespace ProyectoNetCoreCapasADO.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string saludos()
        {
            return "Buenos dias";
        }

        public int numero()
        {
            return 1;
        }


    }
}
