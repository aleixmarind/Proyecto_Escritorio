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
        private List<Proyecto> todosLosProyectos;

        public VerProyectos(Usuario usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;

            // Carpeta Data
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string carpetaData = Path.Combine(projectPath, "Data");
            if (!Directory.Exists(carpetaData))
                Directory.CreateDirectory(carpetaData);

            rutaProyectos = Path.Combine(carpetaData, "proyectos.json");

            if (!File.Exists(rutaProyectos))
                File.WriteAllText(rutaProyectos, "[]");

            // Cargar proyectos al iniciar
            CargarProyectos();
        }

        private void CargarProyectos()
        {
            listBox_Proyectos.Items.Clear();
            listBox_Tareas.Items.Clear();

            try
            {
                string json = File.ReadAllText(rutaProyectos);
                todosLosProyectos = JsonConvert.DeserializeObject<List<Proyecto>>(json) ?? new List<Proyecto>();

                if (todosLosProyectos.Count == 0)
                {
                    listBox_Proyectos.Items.Add("No hay proyectos.");
                    return;
                }

                // Agregar proyectos al ListBox
                foreach (var proyecto in todosLosProyectos)
                {
                    listBox_Proyectos.Items.Add($"{proyecto.Nombre} | Inicio: {proyecto.FechaInicio.ToShortDateString()} | Fin: {proyecto.FechaFin.ToShortDateString()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message);
            }
        }

        private void listBox_Proyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Tareas.Items.Clear();

            int index = listBox_Proyectos.SelectedIndex;
            if (index < 0 || index >= todosLosProyectos.Count)
                return;

            Proyecto proyecto = todosLosProyectos[index];

            // Leer usuarios desde JSON
            string rutaUsuarios = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Data", "usuarios.json");
            List<Usuario> todosLosUsuarios = new List<Usuario>();
            if (File.Exists(rutaUsuarios))
            {
                string jsonUsuarios = File.ReadAllText(rutaUsuarios);
                todosLosUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonUsuarios) ?? new List<Usuario>();
            }

            foreach (var tarea in proyecto.Tareas)
            {
                // Mapear IDs a nombres
                var nombresUsuarios = tarea.UsuariosAsignados
                    .Select(id => todosLosUsuarios.FirstOrDefault(u => u.Id == id)?.Nombre ?? "Desconocido")
                    .ToList();

                string usuariosStr = nombresUsuarios.Count > 0 ? string.Join(", ", nombresUsuarios) : "Sin usuarios";

                listBox_Tareas.Items.Add(
                    $"Tarea: {tarea.Nombre} | Estado: {tarea.Estado} | Prioridad: {tarea.Prioridad} | Inicio: {tarea.FechaInicio.ToShortDateString()} | Fin: {tarea.FechaFin.ToShortDateString()} | Usuarios: {usuariosStr}"
                );
            }

            if (proyecto.Tareas.Count == 0)
                listBox_Tareas.Items.Add("No hay tareas en este proyecto.");
        }


        private void button_Recargar_Click(object sender, EventArgs e)
        {
            CargarProyectos();
        }

        private void button_EliminarProyecto_Click(object sender, EventArgs e)
        {
            int index = listBox_Proyectos.SelectedIndex;
            if (index < 0 || index >= todosLosProyectos.Count)
            {
                MessageBox.Show("Selecciona un proyecto para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar este proyecto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                todosLosProyectos.RemoveAt(index);
                File.WriteAllText(rutaProyectos, JsonConvert.SerializeObject(todosLosProyectos, Formatting.Indented));
                CargarProyectos();
            }
        }

        private void button_MenuPrincipal_Click(object sender, EventArgs e)
        {
            Servicios ventanaServicios = new Servicios(usuario);
            ventanaServicios.Show();
            this.Close();
        }
        private void listBox_Tareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerProyectos_Load(object sender, EventArgs e)
        {

        }

        private void button_EditarProyecto_Click(object sender, EventArgs e)
        {
            int index = listBox_Proyectos.SelectedIndex;
            if (index < 0 || index >= todosLosProyectos.Count)
            {
                MessageBox.Show("Selecciona un proyecto para editar.");
                return;
            }

            // Leer usuarios
            string rutaUsuarios = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Data", "usuarios.json");
            List<Usuario> usuarios = new List<Usuario>();
            if (File.Exists(rutaUsuarios))
            {
                string jsonUsuarios = File.ReadAllText(rutaUsuarios);
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonUsuarios) ?? new List<Usuario>();
            }

            // Abrir formulario EditarProyecto
            EditarProyecto editarForm = new EditarProyecto(todosLosProyectos[index], usuarios, usuario);
            if (editarForm.ShowDialog() == DialogResult.OK)
            {
                // Refrescar lista
                CargarProyectos();
            }
        }
    }
}
