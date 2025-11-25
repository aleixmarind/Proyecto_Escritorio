using System;
using System.Windows.Forms;
using Proyecto_Escritorio.Models;
using Proyecto_Escritorio.Services;
using Proyecto_Escritorio.Forms;

namespace Proyecto_Escritorio.Forms
{
    public partial class Inicio : Form
    {
        private AdminService adminService;

        public Inicio()
        {
            InitializeComponent();
            adminService = new AdminService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMensaje.Text = "Debes introducir email y contraseña";
                return;
            }

            Usuario user = adminService.Login(email, password);

            if (user != null)
            {
                lblMensaje.Text = "";
                // Abrir Servicios pasando el usuario logueado
                Servicios menu = new Servicios(user); // ✅ Pasamos el Usuario
                menu.Show();
                this.Hide();
            }
            else
            {
                lblMensaje.Text = "Credenciales incorrectas";
            }
        }
    }
}
