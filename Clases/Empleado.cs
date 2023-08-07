using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class Empleado : Persona
    {


        public string especialidad { get; set; }
        public bool estado { get; set; }

        public Empleado(int cc, string nombre, int celular, string especialidad, bool estado) : base(cc, nombre, celular)
        {
            this.cc = cc;
            this.nombre = nombre;
            this.celular = celular;
            this.especialidad = especialidad;
            this.estado = estado;
        }
    }

}