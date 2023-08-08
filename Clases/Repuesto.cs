using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class Repuesto
    {
        public string nombreRepuesto { get; set; }
        public int valor { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
        public bool aprobado { get; set; }

        public Repuesto(){}
        public Repuesto (string nombreRepuesto, int valor, int cantidad, int total, bool aprobado)
        {
            this.nombreRepuesto = nombreRepuesto;
            this.valor = valor;
            this.cantidad = cantidad;
            this.total = total;
            this.aprobado = aprobado;
        }
        
        public Repuesto AgregarRepuesto(string nombreRepuesto, int valor, int cantidad, int total)
        {
            Repuesto repuesto = new Repuesto(nombreRepuesto, valor, cantidad, total, true);
            return repuesto;
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
                    aprobado = true;
                    break;
                case 2:
                    aprobado = false;
                    break;
                default:
                Console.WriteLine("Opcion Invalida");
                    break;
            }
        }
    }
}