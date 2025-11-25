using System;
using System.Collections.Generic;

namespace Proyecto_Escritorio.Models
{
    public class Tarea
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid UsuarioAsignadoId { get; set; } // Usuario responsable
        public bool Completada { get; set; }
    }
}
