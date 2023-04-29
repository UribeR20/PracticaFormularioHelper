using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaFormularioHelper.Models;

namespace PracticaFormularioHelper.Controllers
{
    public class equiposController : Controller
    {
        private readonly equiposPrueba _equiposPrueba;
        public equiposController(equiposPrueba equiposPrueba)
        {
            _equiposPrueba= equiposPrueba;
        }


        public IActionResult Index()
        {
            var listadoDeMarcas = (from m in _equiposPrueba.marcas select m).ToList();
            //Manejador de controlador y vista
            ViewData["listadoDeMarcas"] = new SelectList(listadoDeMarcas, "id_marcas", "nombre_marca");
            

            var listadoTiposEquipos = (from tp in _equiposPrueba.tipo_equipo select tp).ToList();
            //Manejador de controlador y vista
            ViewData["listadoTiposEquipos"] = new SelectList(listadoTiposEquipos, "id_tipo_equipo", "descripcion");

            var listadoEstadosEquipos = (from ep in _equiposPrueba.estados_equipo select ep).ToList();
            //Manejador de controlador y vista
            ViewData["listadoEstadosEquipos"] = new SelectList(listadoEstadosEquipos, "id_estados_equipo", "estado");

            return View();
        }
        public IActionResult crearRegistro(equiposs NuevoEquipo) 
        {
            _equiposPrueba.Add(NuevoEquipo);
            _equiposPrueba.SaveChanges();
            return RedirectToAction("Index");
        
        }
    }
}
