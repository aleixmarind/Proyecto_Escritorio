using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Proyecto_Escritorio.Models;

namespace Proyecto_Escritorio.Services
{
    public class ProyectoService
    {
        private string ruta = "Data/proyectos.json";

        public List<Proyecto> Proyectos { get; set; }

        public ProyectoService()
        {
            CargarProyectos();
        }

        private void CargarProyectos()
        {
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                Proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(json) ?? new List<Proyecto>();
            }
            else
            {
                Proyectos = new List<Proyecto>();
            }
        }

        public void AgregarProyecto(Proyecto proyecto)
        {
            Proyectos.Add(proyecto);
            GuardarProyectos();
        }

        public void GuardarProyectos()
        {
            string json = JsonConvert.SerializeObject(Proyectos, Formatting.Indented);
            File.WriteAllText(ruta, json);
        }
    }
}
