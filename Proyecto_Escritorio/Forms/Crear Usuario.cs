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
        private List<Usuario> usuarios; // Lista de usuarios cargados

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
        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
                return;
            }

            string seleccionado = listBoxUsuarios.SelectedItem.ToString();
            string idTexto = seleccionado.Split('—')[0].Trim();

            if (!Guid.TryParse(idTexto, out Guid idUsuario))
            {
                MessageBox.Show("Error al obtener el ID del usuario.");
                return;
            }

            // Encontrar el usuario real
            Usuario usuarioAEliminar = usuarios.Find(u => u.Id == idUsuario);

            if (usuarioAEliminar == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }

            // Eliminarlo de la lista
            usuarios.Remove(usuarioAEliminar);

            // Guardar en JSON
            File.WriteAllText(rutaUsuarios, JsonConvert.SerializeObject(usuarios, Formatting.Indented));

            // 🗑 Eliminar archivo de proyectos del usuario
            string rutaProyectos = Path.Combine(carpetaData, $"proyectos_{usuarioAEliminar.Id}.json");
            if (File.Exists(rutaProyectos))
                File.Delete(rutaProyectos);

            MessageBox.Show("Usuario eliminado correctamente.");

            CargarUsuarios();
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "¿Seguro que quieres eliminar TODOS los usuarios?\n\nEsta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            // 🗑 Borrar todos los archivos proyectos_{id}.json
            foreach (Usuario u in usuarios)
            {
                string rutaProyectos = Path.Combine(carpetaData, $"proyectos_{u.Id}.json");
                if (File.Exists(rutaProyectos))
                    File.Delete(rutaProyectos);
            }

            // Vaciar lista y archivo JSON
            usuarios.Clear();
            File.WriteAllText(rutaUsuarios, "[]");

            MessageBox.Show("Todos los usuarios fueron eliminados.");

            CargarUsuarios();
        }
    }
}
