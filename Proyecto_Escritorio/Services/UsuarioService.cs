using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio.Services
{
    public class UsuarioService
    {
        private string ruta = "Data/admin.json";

        public List<Usuario> Usuarios { get; set; }

        public UsuarioService()
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                Usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
            }
            else
            {
                Usuarios = new List<Usuario>();
            }
        }

        // Método de login
        public Usuario Login(string email, string password)
        {
            return Usuarios.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        // Agregar usuario (opcional)
        public void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            GuardarUsuarios();
        }

        private void GuardarUsuarios()
        {
            string json = JsonConvert.SerializeObject(Usuarios, Formatting.Indented);
            File.WriteAllText(ruta, json);
        }
    }
}
