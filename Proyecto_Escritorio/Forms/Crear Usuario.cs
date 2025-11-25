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
        private string rutaUsuarios;
        private string carpetaData; // ✅ Variable de clase para usar en todo el formulario

        public Crear_Usuario()
        {
            InitializeComponent();

            // 1️⃣ Obtener la ruta de la carpeta raíz del proyecto
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

            // 2️⃣ Crear carpeta Data si no existe en la raíz del proyecto
            carpetaData = Path.Combine(projectPath, "Data");
            if (!Directory.Exists(carpetaData))
                Directory.CreateDirectory(carpetaData);

            // 3️⃣ Ruta completa hacia usuarios.json en la carpeta del proyecto
            rutaUsuarios = Path.Combine(carpetaData, "usuarios.json");

            // Asegurarse de que el archivo exista para no tener problemas al leerlo
            if (!File.Exists(rutaUsuarios))
            {
                File.WriteAllText(rutaUsuarios, "[]");
            }
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

            // Cargar usuarios existentes
            List<Usuario> usuarios = new List<Usuario>();
            string jsonExistente = File.ReadAllText(rutaUsuarios);
            if (!string.IsNullOrWhiteSpace(jsonExistente))
            {
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonExistente) ?? new List<Usuario>();
            }

            // Verificar si ya existe el usuario
            if (usuarios.Exists(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Este usuario ya existe");
                return;
            }

            // Crear el nuevo usuario con ID único
            Usuario nuevoUsuario = new Usuario
            {
                Id = Guid.NewGuid(), // ✅ ID único garantizado
                Email = email,
                Password = password,
                Nombre = nombre
            };

            usuarios.Add(nuevoUsuario);

            // Guardar en JSON en la carpeta del proyecto
            File.WriteAllText(rutaUsuarios, JsonConvert.SerializeObject(usuarios, Formatting.Indented));

            // Crear archivo de proyectos del usuario
            string rutaProyectos = Path.Combine(carpetaData, $"proyectos_{nuevoUsuario.Id}.json");
            if (!File.Exists(rutaProyectos))
            {
                File.WriteAllText(rutaProyectos, "[]");
            }

            MessageBox.Show("Usuario creado correctamente");
            this.Close();
        }
    }
}
