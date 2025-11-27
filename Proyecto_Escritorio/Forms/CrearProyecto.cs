using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio
{
    public partial class CrearProyecto : Form
    {
        private Usuario usuario; // Usuario actual (admin)
        private string rutaProyectos;
        private string carpetaData;
        private List<Usuario> todosLosUsuarios;
        private List<Tarea> tareasTemporal = new List<Tarea>();

        public CrearProyecto(Usuario usuarioActual)
        {
            InitializeComponent();
            usuario = usuarioActual;

            // Obtener la carpeta raíz del proyecto
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

            // Crear carpeta Data si no existe
            carpetaData = Path.Combine(projectPath, "Data");
            if (!Directory.Exists(carpetaData))
                Directory.CreateDirectory(carpetaData);

            // Ruta hacia proyectos.json
            rutaProyectos = Path.Combine(carpetaData, "proyectos.json");

            if (!File.Exists(rutaProyectos))
                File.WriteAllText(rutaProyectos, "[]");
        }


        private void CrearProyecto_Load(object sender, EventArgs e)
        {
            // Cargar usuarios desde JSON
            string rutaUsuarios = Path.Combine(carpetaData, "usuarios.json");
            todosLosUsuarios = new List<Usuario>();

            if (File.Exists(rutaUsuarios))
            {
                string jsonUsuarios = File.ReadAllText(rutaUsuarios);
                if (!string.IsNullOrWhiteSpace(jsonUsuarios))
                    todosLosUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonUsuarios) ?? new List<Usuario>();
            }

            // Llenar CheckedListBox
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = todosLosUsuarios;
            checkedListBox1.DisplayMember = "NombreConEmail";
            checkedListBox1.ValueMember = "Id";

            // Seleccionar automáticamente al admin
            for (int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (todosLosUsuarios[i].Id == usuario.Id)
                    checkedListBox1.SetItemChecked(i, true);
            }
        }


        private void button_Tarea_Click(object sender, EventArgs e)
        {
            // Filtrar solo los usuarios seleccionados
            List<Usuario> usuariosSeleccionados = new List<Usuario>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (item is Usuario u)
                    usuariosSeleccionados.Add(u);
            }

            if (usuariosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un usuario para asignar tareas.");
                return;
            }

            CrearTarea ventanaTarea = new CrearTarea(usuariosSeleccionados, usuario);

            if (ventanaTarea.ShowDialog() == DialogResult.OK)
            {
                if (ventanaTarea.tareaCreada != null)
                {
                    tareasTemporal.Add(ventanaTarea.tareaCreada);
                    MessageBox.Show($"Tarea añadida correctamente.\nTotal tareas: {tareasTemporal.Count}");
                }
            }
        }



        private void button_CrearProyecto_Click(object sender, EventArgs e)
        {
            string nombre = textBox_NombreProyecto.Text.Trim();
            string descripcion = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debes ingresar un nombre para el proyecto.");
                return;
            }

            // Cargar proyectos existentes
            List<Proyecto> proyectos = new List<Proyecto>();

            if (File.Exists(rutaProyectos))
            {
                string jsonExistente = File.ReadAllText(rutaProyectos);
                if (!string.IsNullOrWhiteSpace(jsonExistente))
                    proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(jsonExistente) ?? new List<Proyecto>();
            }

            // Obtener usuarios asignados
            List<Guid> usuariosAsignados = new List<Guid>();
            foreach (Usuario u in checkedListBox1.CheckedItems)
            {
                usuariosAsignados.Add(u.Id);
            }

            // Crear nuevo proyecto
            Proyecto nuevoProyecto = new Proyecto
            {
                Id = Guid.NewGuid(),
                Nombre = nombre,
                Descripcion = descripcion,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now.AddDays(7),
                UsuariosAsignados = usuariosAsignados, // IDs de usuarios del proyecto
                Tareas = tareasTemporal // ✅ Aquí se guardan las tareas con sus usuarios
            };

            // Guardar en JSON
            proyectos.Add(nuevoProyecto);
            File.WriteAllText(rutaProyectos, JsonConvert.SerializeObject(proyectos, Formatting.Indented));


            MessageBox.Show("Proyecto creado con éxito con " + tareasTemporal.Count + " tareas.");

            Servicios paginaServicios = new Servicios(usuario);
            paginaServicios.Show();
            this.Close();
        }


        private void textBox_NombreProyecto_TextChanged(object sender, EventArgs e) { }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
