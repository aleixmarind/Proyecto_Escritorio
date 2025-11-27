using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio
{
    public partial class CrearTarea : Form
    {
        private List<Usuario> usuariosDisponibles;
        private List<Usuario> todosLosUsuarios;
        private string carpetaData;
        private Usuario usuario; // Usuario actual (admin)


        // Para devolver la tarea creada al formulario padre
        public Tarea tareaCreada { get; private set; }

        // Constructor: recibe lista de usuarios o la carga desde JSON
        public CrearTarea(List<Usuario> usuarios = null)
        {
            InitializeComponent();
            usuariosDisponibles = usuarios; // Si viene desde CrearProyecto
        }

        private void CrearTarea_Load(object sender, EventArgs e)
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
            checkedListBox_Compartir.DataSource = null;
            checkedListBox_Compartir.DataSource = todosLosUsuarios;
            checkedListBox_Compartir.DisplayMember = "NombreConEmail";
            checkedListBox_Compartir.ValueMember = "Id";

            // Seleccionar automáticamente al admin
            for (int i = 0; i < todosLosUsuarios.Count; i++)
            {
                if (todosLosUsuarios[i].Id == usuario.Id)
                    checkedListBox_Compartir.SetItemChecked(i, true);
            }
        }

        // -------------------------------
        // CARGAR USUARIOS DESDE JSON
        // -------------------------------
       
  

        // -------------------------------
        // RELLENAR CONTROLES
        // -------------------------------
        private void buttonAñadirTarea_Click(object sender, EventArgs e)
        {
            string nombre = textBox_Nombre.Text.Trim();
            string descripcion = textBox_Descripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debes introducir un nombre para la tarea.");
                return;
            }

            if (checkedListBox_Estado.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debes seleccionar un estado.");
                return;
            }

            if (checkedListBoxPrioridad.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debes seleccionar una prioridad.");
                return;
            }

            string estado = checkedListBox_Estado.CheckedItems[0].ToString();
            string prioridad = checkedListBoxPrioridad.CheckedItems[0].ToString();

            // Obtener usuarios asignados comparando con la lista original
            List<Guid> asignados = new List<Guid>();
            for (int i = 0; i < checkedListBox_Compartir.CheckedItems.Count; i++)
            {
                string nombreConEmail = checkedListBox_Compartir.CheckedItems[i].ToString();
                Usuario u = usuariosDisponibles.Find(x => x.NombreConEmail == nombreConEmail);
                if (u != null)
                    asignados.Add(u.Id);
            }

            tareaCreada = new Tarea
            {
                Id = Guid.NewGuid(),
                Nombre = nombre,
                Descripcion = descripcion,
                Estado = estado,
                Prioridad = prioridad,
                UsuariosAsignados = asignados,
                FechaCreacion = DateTime.Now,
                FechaInicio = dateTimePickerFechaInicio.Value,
                FechaFin = dateTimePickerFechaFinalización.Value
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // -------------------------------
        // EVENTOS VACÍOS NECESARIOS PARA DISEÑADOR
        // -------------------------------
        private void groupBox_Detalles_Enter(object sender, EventArgs e) { }
        private void textBox_Nombre_TextChanged(object sender, EventArgs e) { }
        private void textBox_Descripcion_TextChanged(object sender, EventArgs e) { }
        private void checkedListBox_Compartir_SelectedIndexChanged(object sender, EventArgs e) { }
        private void checkedListBox_Estado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void checkedListBoxPrioridad_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePickerFechaFinalización_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
    }
}
