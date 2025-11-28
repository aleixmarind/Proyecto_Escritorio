using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio
{
    public partial class EditarProyecto : Form
    {
        private Proyecto proyecto;
        private Usuario usuarioActual;
        private List<Usuario> todosLosUsuarios;
        private string rutaProyectos;

        public EditarProyecto(Proyecto proyectoSeleccionado, List<Usuario> usuarios, Usuario usuarioLogueado)
        {
            InitializeComponent();

            proyecto = proyectoSeleccionado;
            todosLosUsuarios = usuarios;
            usuarioActual = usuarioLogueado;

            // Ruta JSON
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string carpetaData = Path.Combine(projectPath, "Data");
            rutaProyectos = Path.Combine(carpetaData, "proyectos.json");

            CargarDatosProyecto();
        }

        private void CargarDatosProyecto()
        {
            // Campos del proyecto
            textBox_Nombre.Text = proyecto.Nombre;
            textBox_Descripcion.Text = proyecto.Descripcion;
            dateTimePicker_FechaInicio.Value = proyecto.FechaInicio;
            dateTimePicker_FechaFin.Value = proyecto.FechaFin;

            // Usuarios del proyecto
            checkedListBox_Usuarios.DataSource = null;
            checkedListBox_Usuarios.DataSource = todosLosUsuarios;
            checkedListBox_Usuarios.DisplayMember = "NombreConEmail";
            checkedListBox_Usuarios.ValueMember = "Id";

            for (int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (proyecto.UsuariosAsignados.Contains(todosLosUsuarios[i].Id))
                    checkedListBox_Usuarios.SetItemChecked(i, true);
            }

            // Tareas del proyecto
            listBox_Tareas.Items.Clear();
            foreach (var t in proyecto.Tareas)
                listBox_Tareas.Items.Add(t.Nombre);

            // Limpiar usuarios de tarea al inicio
            checkedListBox_UsuariosTarea.DataSource = null;
        }

        // Selección de tarea -> mostrar usuarios asignados
        private void listBox_Tareas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = listBox_Tareas.SelectedIndex;
            if (index < 0 || index >= proyecto.Tareas.Count)
            {
                checkedListBox_UsuariosTarea.DataSource = null;
                return;
            }

            Tarea tarea = proyecto.Tareas[index];

            checkedListBox_UsuariosTarea.DataSource = null;
            checkedListBox_UsuariosTarea.DataSource = todosLosUsuarios;
            checkedListBox_UsuariosTarea.DisplayMember = "NombreConEmail";
            checkedListBox_UsuariosTarea.ValueMember = "Id";

            for (int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (tarea.UsuariosAsignados.Contains(todosLosUsuarios[i].Id))
                    checkedListBox_UsuariosTarea.SetItemChecked(i, true);
            }
        }

        // Cambiar usuarios asignados de la tarea
        private void checkedListBox_UsuariosTarea_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            int tareaIndex = listBox_Tareas.SelectedIndex;
            if (tareaIndex < 0 || tareaIndex >= proyecto.Tareas.Count) return;

            Tarea tarea = proyecto.Tareas[tareaIndex];
            Usuario usuario = (Usuario)checkedListBox_UsuariosTarea.Items[e.Index];

            if (e.NewValue == CheckState.Checked)
            {
                // Se está marcando
                if (!tarea.UsuariosAsignados.Contains(usuario.Id))
                    tarea.UsuariosAsignados.Add(usuario.Id);
            }
            else
            {
                // Se está desmarcando
                if (tarea.UsuariosAsignados.Contains(usuario.Id))
                    tarea.UsuariosAsignados.Remove(usuario.Id);
            }
        }

        // Guardar proyecto y tareas
        private void button_Guardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Nombre.Text))
            {
                MessageBox.Show("Debes ingresar un nombre para el proyecto.");
                return;
            }

            // Actualizar datos del proyecto
            proyecto.Nombre = textBox_Nombre.Text.Trim();
            proyecto.Descripcion = textBox_Descripcion.Text.Trim();
            proyecto.FechaInicio = dateTimePicker_FechaInicio.Value;
            proyecto.FechaFin = dateTimePicker_FechaFin.Value;

            // Actualizar usuarios del proyecto
            proyecto.UsuariosAsignados = new List<Guid>();
            foreach (Usuario u in checkedListBox_Usuarios.CheckedItems)
                proyecto.UsuariosAsignados.Add(u.Id);

            // Validar que ninguna tarea tenga usuarios fuera del proyecto
            foreach (var tarea in proyecto.Tareas)
            {
                tarea.UsuariosAsignados = tarea.UsuariosAsignados
                    .Where(id => proyecto.UsuariosAsignados.Contains(id))
                    .ToList();
            }

            // Leer proyectos existentes
            List<Proyecto> proyectos = new List<Proyecto>();
            if (File.Exists(rutaProyectos))
            {
                string json = File.ReadAllText(rutaProyectos);
                proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(json) ?? new List<Proyecto>();
            }

            // Reemplazar proyecto editado
            int index = proyectos.FindIndex(p => p.Id == proyecto.Id);
            if (index >= 0)
                proyectos[index] = proyecto;

            // Guardar JSON
            File.WriteAllText(rutaProyectos, JsonConvert.SerializeObject(proyectos, Formatting.Indented));

            MessageBox.Show("Proyecto y tareas actualizadas correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkedListBox_UsuariosTareas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Código
        }

    }
}
