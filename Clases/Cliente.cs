using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class Cliente : Persona
    {
        public string email;
        public string fechaRegistro;

        public Cliente(int cc, string nombre, int celular, string email, string fechaRegistro) : base(cc, nombre, celular)
        {
            this.cc = cc;
            this.nombre = nombre;
            this.celular = celular;
            this.email = email;
            this.fechaRegistro = fechaRegistro;
        }
    }
}