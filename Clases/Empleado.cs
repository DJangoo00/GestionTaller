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
        public void Mostrar ()
        {
            Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-20}|{4,-10}", cc, nombre, celular, especialidad, estado));
        }
        public void CambiarEstado()
        {
            Console.WriteLine("Ingrese la opcion segun corrresponda: ");
            Console.WriteLine("1. Activo ");
            Console.WriteLine("2. Inactivo ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    estado = true;
                    break;
                case 2:
                    estado = false;
                    break;
                default:
                Console.WriteLine("Opcion Invalida");
                    break;
            }
        }
    }

}