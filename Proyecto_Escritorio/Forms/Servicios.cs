using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escritorio.Forms;

namespace Proyecto_Escritorio
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void button_CerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void button_CrearProyectos_Click(object sender, EventArgs e)
        {
            CrearProyecto crearProyecto = new CrearProyecto();
            crearProyecto.Show();
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Crear_Usuario crear = new Crear_Usuario();
            crear.ShowDialog();
        }

        private void button_GestionarProyecto_Click(object sender, EventArgs e)
        {
            GestionProyectos gestionProyectos = new GestionProyectos();
            gestionProyectos.Show();
            this.Close();
        }

        private void button_CrearUsuarios_Click(object sender, EventArgs e)
        {
            Crear_Usuario crear = new Crear_Usuario();
            crear.ShowDialog();
        }
    }
}
