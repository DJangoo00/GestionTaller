using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class DiagnosticoExperto
    {
        public string diagnostico { get; set; }
        public int ccEmpleado { get; set; }
        
        public DiagnosticoExperto (string diagnostico, int ccEmpleado)
        {
            this.diagnostico = diagnostico;
            this.ccEmpleado = ccEmpleado;
        }
    }
}