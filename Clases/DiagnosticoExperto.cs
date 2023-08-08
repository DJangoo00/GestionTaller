using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class DiagnosticoExperto
    {
        public int idDiagnosticoExperto { get; set; }
        public string diagnostico { get; set; }
        public int ccEmpleado { get; set; }
        
        public DiagnosticoExperto(){}
        public DiagnosticoExperto (int idDiagnosticoExperto, string diagnostico, int ccEmpleado)
        {
            
            this.diagnostico = diagnostico;
            this.ccEmpleado = ccEmpleado;
            this.idDiagnosticoExperto = idDiagnosticoExperto;
        }
        public DiagnosticoExperto AgregarDiagnostico (int idDiagnosticoExperto, string diagnostico, int ccEmpleado)
        {
            DiagnosticoExperto diagnosticoExperto = new DiagnosticoExperto(idDiagnosticoExperto, diagnostico, ccEmpleado);
            return diagnosticoExperto;
        }
    }
}