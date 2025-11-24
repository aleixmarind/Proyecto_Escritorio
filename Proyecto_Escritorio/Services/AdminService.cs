using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio.Services
{
    public class AdminService
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "admin.json");
        public List<Usuario> Admins { get; set; }

        public AdminService()
        {
            CargarAdmins();
        }

        private void CargarAdmins()
        {
            // Crear carpeta Data si no existe
            Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            if (!File.Exists(ruta))
            {
                // Crear admin por defecto
                var admin = new Usuario
                {
                    Email = "admin@gmail.com",
                    Password = "1234",
                    Nombre = "Administrador"
                };
                Admins = new List<Usuario> { admin };
                File.WriteAllText(ruta, JsonConvert.SerializeObject(Admins, Formatting.Indented));
            }
            else
            {
                string json = File.ReadAllText(ruta);
                Admins = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
            }
        }

        public Usuario Login(string email, string password)
        {
            return Admins.Find(a => a.Email == email && a.Password == password);
        }
    }
}
