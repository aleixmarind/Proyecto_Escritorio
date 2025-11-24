using System;
using System.Collections.Generic;

namespace Proyecto_Escritorio.Models
{
    public class Tarea
    {
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string AsignadoA { get; set; }

        // Cada tarea tiene una lista de subtareas
        public List<SubTarea> SubTareas { get; set; } = new List<SubTarea>();
    }
}
