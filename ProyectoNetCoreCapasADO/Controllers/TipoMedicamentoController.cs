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

        /// <summary>
        /// Retorna un saludo
        /// </summary>
        /// <returns></returns>
        public string saludo()
        {
            return "Hola amigos";
        }

        /// <summary>
        /// Retorna un entero
        /// </summary>
        /// <returns></returns>
        public int numeroEntero()
        {
            return 10;
        }

        public double numeroDouble()
        {
            return 5.0;
        }

        public string saludoNombre(string Nombre)
        {
            return "Bienvenido"+Nombre;
        }

        public List<TipoMedicamentoCLS> listarTipoMedicamento()
        {
            //El controller se comunica con la capa de negocio
            TipoMedicamentoBL obj = new TipoMedicamentoBL();
            return obj.listarMedicamentos();
        }
    }
}
