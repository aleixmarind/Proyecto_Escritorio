using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;
using System.IO;

namespace Proyecto_Escritorio.Forms
{
    public partial class Crear_Usuario : Form
    {
        private string rutaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "usuarios.json");

        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void Crear_Usuario_Load(object sender, EventArgs e)
        {
        }

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }

            // 🔹 Asegurar que la carpeta Data existe
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data"));

            // 🔹 Leer usuarios existentes o crear lista vacía
            List<Usuario> usuarios = new List<Usuario>();
            if (File.Exists(rutaUsuarios))
            {
                string json = File.ReadAllText(rutaUsuarios);
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
            }

            // 🔹 Comprobar si el usuario ya existe
            if (usuarios.Exists(u => u.Email == email))
            {
                MessageBox.Show("Este usuario ya existe");
                return;
            }

            // 🔹 Crear el nuevo usuario
            var nuevoUsuario = new Usuario
            {
                Email = email,
                Password = password,
                Nombre = nombre
            };
            usuarios.Add(nuevoUsuario);

            // 🔹 Guardar en usuarios.json
            File.WriteAllText(rutaUsuarios, JsonConvert.SerializeObject(usuarios, Formatting.Indented));

            // 🔹 Crear JSON vacío de proyectos para este usuario
            string rutaProyectos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data",
                $"proyectos_{email.Replace("@", "_").Replace(".", "_")}.json");

            if (!File.Exists(rutaProyectos))
            {
                File.WriteAllText(rutaProyectos, "[]"); // JSON vacío
            }

            MessageBox.Show("Usuario creado correctamente");
            this.Close();
        }
    }
}
