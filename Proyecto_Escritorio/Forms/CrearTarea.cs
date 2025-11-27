using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio
{
    public partial class CrearTarea : Form
    {
        private List<Usuario> usuariosDisponibles;
        private Usuario usuario; // usuario actual (admin)

        // Para devolver la tarea creada
        public Tarea tareaCreada { get; private set; }

        // Constructor: recibe lista de usuarios y usuario actual
        public CrearTarea(List<Usuario> usuarios, Usuario usuarioActual)
        {
            InitializeComponent();
            usuariosDisponibles = usuarios ?? new List<Usuario>();
            usuario = usuarioActual;
        }

        private void CrearTarea_Load(object sender, EventArgs e)
        {
            if (usuariosDisponibles == null || usuariosDisponibles.Count == 0)
                return;

            checkedListBox_Compartir.DataSource = null;  // Reset
            checkedListBox_Compartir.DataSource = usuariosDisponibles;
            checkedListBox_Compartir.DisplayMember = "NombreConEmail"; // Debe existir en la clase Usuario
            checkedListBox_Compartir.ValueMember = "Id";

            // Marcar automáticamente al admin si está en la lista
            for (int i = 0; i < usuariosDisponibles.Count; i++)
            {
                if (usuariosDisponibles[i].Id == usuario.Id)
                    checkedListBox_Compartir.SetItemChecked(i, true);
            }
        }


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

            // Obtener usuarios asignados
            List<Guid> asignados = new List<Guid>();
            foreach (Usuario u in checkedListBox_Compartir.CheckedItems)
            {
                asignados.Add(u.Id);
            }

            tareaCreada = new Tarea
            {
                Id = Guid.NewGuid(),
                Nombre = nombre,
                Descripcion = descripcion,
                Estado = estado,
                Prioridad = prioridad,
                UsuariosAsignados = asignados, // ✅ Aquí se guardan los IDs
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

        // Eventos vacíos necesarios para diseñador
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
