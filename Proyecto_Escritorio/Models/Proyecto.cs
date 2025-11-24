using System;
using System.Collections.Generic;

namespace Proyecto_Escritorio.Models
{
    public class Proyecto
    {
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        // Cada proyecto tiene una lista de tareas
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
