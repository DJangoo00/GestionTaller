using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class OrdenAprovacion
    {
        public int ccEmpleado { get; set; }
        public string fecha { get; set; }
        public bool aprovada { get; set; }

        public OrdenAprovacion (int ccEmpleado, string fecha, bool aprovada)
        {
            this.ccEmpleado = ccEmpleado;
            this.fecha = fecha;
            this.aprovada = aprovada;
        }
    }
}