using System;
using System.Windows.Forms;
using Proyecto_Escritorio.Forms;

namespace Proyecto_Escritorio
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button_Entrar_Click(object sender, EventArgs e)
        {
            Inicio crear = new Inicio();
            crear.ShowDialog();
            this.Hide();
        }
    }
}
