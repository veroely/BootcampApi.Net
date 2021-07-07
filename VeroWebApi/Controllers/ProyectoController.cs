using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace VeroWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        [HttpGet]
        public IActionResult getAll() 
        {

            List<Proyecto> lProyectos = listarProyectos();
            return Ok(lProyectos);
        }

        public List<Proyecto> listarProyectos() 
        {
            List<Proyecto> lista = new List<Proyecto>() {
                new Proyecto() { ProyectoId = 1, Nombre = "Sistema Médico", Autor = "Carlos" },
                new Proyecto() { ProyectoId = 2, Nombre = "App Envio de dinero", Autor = "Mario" },
                new Proyecto() { ProyectoId = 3, Nombre = "Sistema para Selección de Personal", Autor = "Francisca" }
            };

            return lista;
        }
    }
}
