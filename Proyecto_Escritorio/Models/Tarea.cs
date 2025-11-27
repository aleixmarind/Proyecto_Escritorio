using System;
using System.Collections.Generic;

namespace Proyecto_Escritorio.Models
{
    public class Tarea
    {
        // Id único de la tarea
        public Guid Id { get; set; } = Guid.NewGuid();

        // Datos básicos
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Compatibilidad: si usas asignación simple a un usuario
        // (mantenemos esta propiedad para código antiguo)
        public Guid? UsuarioAsignadoId { get; set; }

        // Asignación múltiple (proyecto compartido): lista de IDs de usuarios
        public List<Guid> UsuariosAsignados { get; set; } = new List<Guid>();

        // Estado y prioridad
        public string Estado { get; set; } = "Pendiente"; // ejemplo: "Pendiente", "En progreso", "Completada"
        public string Prioridad { get; set; } = "Media";  // ejemplo: "Baja", "Media", "Alta"

        // Fechas
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFin { get; set; } = DateTime.Now.AddDays(1);

        // Marca si está completada (por si tu código usa esto en vez de Estado)
        public bool Completada { get; set; } = false;
    }
}
