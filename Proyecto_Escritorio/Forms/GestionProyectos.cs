using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button_VerProyectos_Click(object sender, EventArgs e)
        {
            VerProyectos gestionProyectos = new VerProyectos(usuarioLogueado); // ✅ Pasamos el usuario
            gestionProyectos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
