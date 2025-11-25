using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio.Forms
{
    public partial class VerUsuarios : Form
    {
        private string rutaUsuarios;
        private List<Usuario> usuarios; // Lista de usuarios cargados

        public VerUsuarios()
        {
            InitializeComponent();

            // Obtener la ruta de la carpeta raíz del proyecto
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

            // Crear carpeta Data si no existe
            string dataFolder = Path.Combine(projectPath, "Data");
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }

            // Ruta completa hacia Data/usuarios.json
            rutaUsuarios = Path.Combine(dataFolder, "usuarios.json");

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            listBoxUsuarios.Items.Clear();

            if (!File.Exists(rutaUsuarios))
            {
                MessageBox.Show("El archivo usuarios.json no existe. Se creará uno nuevo al guardar usuarios.");
                usuarios = new List<Usuario>();
                return;
            }

            try
            {
                string json = File.ReadAllText(rutaUsuarios);

                if (string.IsNullOrWhiteSpace(json) || !json.Trim().StartsWith("["))
                {
                    MessageBox.Show("El JSON de usuarios está vacío o dañado.");
                    usuarios = new List<Usuario>();
                    return;
                }

                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();

                foreach (var u in usuarios)
                {
                    listBoxUsuarios.Items.Add($"{u.Id} — {u.Email} — {u.Nombre}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer usuarios: " + ex.Message);
                usuarios = new List<Usuario>();
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void GuardarUsuarios(List<Usuario> usuarios)
        {
            try
            {
                string json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText(rutaUsuarios, json);
                MessageBox.Show("Usuarios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuarios: " + ex.Message);
            }
        }

        private void label_CrearUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (usuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios para pasar al menú principal.");
                return;
            }

            // Aquí puedes elegir qué usuario pasar, por ejemplo el primero:
            Usuario usuarioLogueado = usuarios[0];

            Servicios gestionProyectos = new Servicios(usuarioLogueado);
            gestionProyectos.Show();
            this.Close();
        }
    }
}
