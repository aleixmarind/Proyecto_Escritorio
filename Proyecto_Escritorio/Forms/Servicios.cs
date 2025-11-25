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
using Proyecto_Escritorio.Models; // Asegúrate de usar el namespace correcto para Usuario

namespace Proyecto_Escritorio
{
    public partial class Servicios : Form
    {
        // Variable para el usuario logueado
        private Usuario usuarioLogueado;

        // Constructor que recibe el usuario logueado
        public Servicios(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void button_CerrarSesion_Click(object sender, EventArgs e)
        {
            Inicio crear = new Inicio();
            crear.ShowDialog();
            this.Close();
        }

        private void button_CrearProyectos_Click(object sender, EventArgs e)
        {
            // Pasamos el usuario logueado al formulario CrearProyecto
            CrearProyecto crearProyecto = new CrearProyecto(usuarioLogueado);
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
            GestionProyectos gestion = new GestionProyectos(usuarioLogueado);
            gestion.Show();
            this.Close();
        }

        private void button_CrearUsuarios_Click(object sender, EventArgs e)
        {
            Crear_Usuario crear = new Crear_Usuario();
            crear.ShowDialog();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {

        }

        private void button_VerUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios crear = new VerUsuarios();
            crear.ShowDialog();
        }
    }
}
