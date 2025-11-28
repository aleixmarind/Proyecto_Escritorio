using System;
using System.Windows.Forms;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio
{
    public partial class GestionProyectos : Form
    {
        private Usuario usuarioLogueado;

        public GestionProyectos(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void btnVerProyectos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario VerProyectos, pasando el usuario
            VerProyectos ventanaVer = new VerProyectos(usuarioLogueado);
            ventanaVer.Show();

            // Cerrar la actual si quieres
            // this.Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            // Abrir la página principal (Servicios), pasando el usuario
            Servicios ventanaServicios = new Servicios(usuarioLogueado);
            ventanaServicios.Show();

            // Cerrar la ventana actual
            this.Close();
        }
    }
}
