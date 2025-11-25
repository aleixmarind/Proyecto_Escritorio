using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio
{
    public partial class VerProyectos : Form
    {
        private Usuario usuario; // Usuario logueado
        private string rutaProyectos;
        private List<Proyecto> proyectosUsuario;

        public VerProyectos(Usuario usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;

            // Obtener carpeta Data en la raíz del proyecto
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string carpetaData = Path.Combine(projectPath, "Data");
            if (!Directory.Exists(carpetaData))
                Directory.CreateDirectory(carpetaData);

            // Ruta completa hacia proyectos.json
            rutaProyectos = Path.Combine(carpetaData, "proyectos.json");

            // Crear archivo vacío si no existe
            if (!File.Exists(rutaProyectos))
                File.WriteAllText(rutaProyectos, "[]");

            CargarProyectos();
        }

        private void CargarProyectos()
        {
            listBoxProyectos.Items.Clear();

            try
            {
                string json = File.ReadAllText(rutaProyectos);
                List<Proyecto> todosLosProyectos = JsonConvert.DeserializeObject<List<Proyecto>>(json) ?? new List<Proyecto>();

                // Filtrar solo los proyectos donde el usuario está asignado
                proyectosUsuario = todosLosProyectos
                    .Where(p => p.UsuariosAsignados.Contains(usuario.Id))
                    .ToList();

                foreach (var proyecto in proyectosUsuario)
                {
                    listBoxProyectos.Items.Add($"{proyecto.Nombre} ({proyecto.FechaInicio.ToShortDateString()} - {proyecto.FechaFin.ToShortDateString()})");
                }

                if (proyectosUsuario.Count == 0)
                    listBoxProyectos.Items.Add("No tienes proyectos asignados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message);
            }
        }

        private void listBoxProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTareas.Items.Clear();

            int index = listBoxProyectos.SelectedIndex;
            if (index < 0 || index >= proyectosUsuario.Count)
                return;

            Proyecto proyectoSeleccionado = proyectosUsuario[index];

            // Filtrar solo tareas asignadas al usuario logueado
            var tareasUsuario = proyectoSeleccionado.Tareas
                .Where(t => t.UsuarioAsignadoId == usuario.Id)
                .ToList();

            foreach (var tarea in tareasUsuario)
            {
                listBoxTareas.Items.Add($"{tarea.Nombre} - {(tarea.Completada ? "Completada" : "Pendiente")}");
            }

            if (tareasUsuario.Count == 0)
                listBoxTareas.Items.Add("No tienes tareas asignadas en este proyecto.");
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarProyectos();
        }
    }
}
