using System;

namespace Proyecto_Escritorio.Models
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // ? ID público, serializable
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }       
        public string NombreConEmail
        {
            get { return $"{Nombre} ({Email})"; }
        }
        public override string ToString()
        {
            return NombreConEmail;
        }


    }
}
