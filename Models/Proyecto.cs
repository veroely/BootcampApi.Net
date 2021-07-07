using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Autor { get; set; }
    }
}
