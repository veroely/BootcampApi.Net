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
        public IActionResult getAllProyectos() 
        {

            List<Proyecto> lista = new List<Proyecto>();
            lista.Add(new Proyecto() { ProyectoId = 1, Nombre = "Sistema Médico", Autor = "Carlos" });
            lista.Add(new Proyecto() { ProyectoId = 2, Nombre = "App Envio de dinero", Autor = "Mario" });
            lista.Add(new Proyecto() { ProyectoId = 3, Nombre = "Sistema para Selección de Personal", Autor = "Francisca" });

            return Ok(lista);
        }
    }
}
