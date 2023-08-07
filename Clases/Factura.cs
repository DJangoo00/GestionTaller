using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class Factura
    {
        public int idFactura { get; set; }
        public int numOrden { get; set; }
        public int ccCliente { get; set; }
        public int subtotal { get; set; }
        public int iva { get; set; }
        public int valorObra { get; set; }
        public int total { get; set; }

        public Factura (int idFactura, int numOrden, int ccCliente, int subtotal, int iva, int valorObra, int total)
        {
            this.idFactura = idFactura;
            this.numOrden = numOrden;
            this.ccCliente = ccCliente;
            this.subtotal = subtotal;
            this.iva = iva;
            this.valorObra = valorObra;
            this.total = total;
        }
    }
}