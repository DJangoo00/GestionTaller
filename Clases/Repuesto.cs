using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class Repuesto
    {
        public int valor { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
        public bool aprobado { get; set; }

        public Repuesto (int valor, int cantidad, int total, bool aprobado)
        {
            this.valor = valor;
            this.cantidad = cantidad;
            this.total = total;
            this.aprobado = aprobado;
        }
    }
}