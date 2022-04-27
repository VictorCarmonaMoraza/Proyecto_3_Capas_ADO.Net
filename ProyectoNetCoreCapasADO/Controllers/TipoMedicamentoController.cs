using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProyectoNetCoreCapasADO.Controllers
{

    public class TipoMedicamentoController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult SinMenu()
        {
            return View();
        }
        //string
        public string saludo()
        {
            return "Hola amigos";
        }
        public string saludoNombre(string nombre)
        {
            return "Bienvenido " + nombre;
        }
        public string saludoNombreApellido(string nombre, string apellido)
        {
            return "Bienvenido " + nombre + " " + apellido;
        }
        public int numeroentero()
        {
            return 10;
        }
        public double numerodecimal()
        {
            return 5.6;
        }

        public List<TipoMedicamentoCLS> listarTipoMedicamento()
        {
            TipoMedicamentoBL obj = new TipoMedicamentoBL();
            return obj.listarMedicamentos();
        }

    }
}
