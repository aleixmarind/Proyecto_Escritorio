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
        private string carpetaData; // carpeta Data
        private List<Usuario> todosLosUsuarios; // lista de todos los usuarios

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

            // Ruta completa hacia proyectos.json
            rutaProyectos = Path.Combine(carpetaData, "proyectos.json");

            // Crear archivo vacío si no existe
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

            // Llenar CheckedListBox usando DataSource
            checkedListBox1.DataSource = null; // Limpiar primero
            checkedListBox1.DataSource = todosLosUsuarios;
            checkedListBox1.DisplayMember = "NombreConEmail";  // Nueva propiedad calculada
            checkedListBox1.ValueMember = "Id";

            // Marcar automáticamente al usuario admin que crea el proyecto
            for (int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (todosLosUsuarios[i].Id == usuario.Id)
                    checkedListBox1.SetItemChecked(i, true);
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

            // Obtener IDs de los usuarios seleccionados
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
                UsuariosAsignados = usuariosAsignados,
                Tareas = new List<Tarea>()
            };

            proyectos.Add(nuevoProyecto);

            // Guardar proyectos en JSON
            File.WriteAllText(rutaProyectos, JsonConvert.SerializeObject(proyectos, Formatting.Indented));

            MessageBox.Show("Proyecto creado con éxito.");

            // Abrir Servicios pasando el usuario admin
            Servicios paginaServicios = new Servicios(usuario);
            paginaServicios.Show();
            this.Close();
        }

        private void textBox_NombreProyecto_TextChanged(object sender, EventArgs e) { }

        private void button_Tarea_Click(object sender, EventArgs e) { }
    }
}
