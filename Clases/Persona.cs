using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class Persona
    {
        public int cc { get; set; }
        public string nombre { get; set; }
        public int celular { get; set; }

        public Persona(int cc, string nombre, int celular)
        {
            this.cc = cc;
            this.nombre = nombre;
            this.celular = celular;
        }
        
    }
}