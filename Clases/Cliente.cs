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
        public void Mostrar()
        {
            Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}", cc, nombre, celular, email, fechaRegistro));
        }
    }

}