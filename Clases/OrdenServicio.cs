using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class OrdenServicio
    {
        public int idOrden { get; set; }
        public int ccCliente { get; set; }
        public int ccEmpleado { get; set; }
        public string fechaOrden { get; set; }
        public string placa { get; set; }
        public int km { get; set; }
        public string diagnosticoCliente { get; set; }

        public OrdenServicio(int idOrden, int ccCliente, int ccEmpleado, string fechaOrden, string placa, int km, string diagnosticoCliente)
        {
            this.idOrden = idOrden;
            this.ccCliente = ccCliente;
            this.ccEmpleado = ccEmpleado;
            this.fechaOrden = fechaOrden;
            this.placa = placa;
            this.km = km;
            this.diagnosticoCliente = diagnosticoCliente;
        }
    }
}