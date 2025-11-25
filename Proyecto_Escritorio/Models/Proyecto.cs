using System;
using System.Collections.Generic;

namespace Proyecto_Escritorio.Models
{
    public class Proyecto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Guid> UsuariosAsignados { get; set; } = new List<Guid>(); // IDs de usuarios
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
