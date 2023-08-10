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
        public List<int> diagnosticosExpertos { get; set; }

        public OrdenServicio (){}
        public OrdenServicio(int idOrden, int ccCliente, int ccEmpleado, string fechaOrden, string placa, int km, string diagnosticoCliente)
        {
            this.idOrden = idOrden;
            this.ccCliente = ccCliente;
            this.ccEmpleado = ccEmpleado;
            this.fechaOrden = fechaOrden;
            this.placa = placa;
            this.km = km;
            this.diagnosticoCliente = diagnosticoCliente;
            this.diagnosticosExpertos = new List<int>();
        }
        public OrdenServicio AgregarServicio (int idOrden, int ccCliente, int ccEmpleado, string fechaOrden, string placa, int km, string diagnosticoCliente)
        {
            OrdenServicio servicio = new OrdenServicio(idOrden, ccCliente, ccEmpleado, fechaOrden, placa, km, diagnosticoCliente);
            return servicio;
        }
        public OrdenServicio AgregarServicio() 
        {
            OrdenServicio ordenServicio = new OrdenServicio (idOrden, ccCliente, ccEmpleado, fechaOrden, placa, km, diagnosticoCliente);
            return ordenServicio;
        }
        public void mostrarServicio()
        {
            //por implementar
            Console.WriteLine("***********************************************************");
            Console.WriteLine(String.Format("{0,-1}|{1,15}","Numero de Orden:", idOrden));
            Console.WriteLine(String.Format("{0,-11}|{1,15}","CC de Cliente:", ccCliente));
            Console.WriteLine(String.Format("{0,-12}|{1,15}","CC de Empleado:", ccEmpleado));
        }
        public void AgregarDiagnostico(int idDiagnosticoExperto)
        {
            diagnosticosExpertos.Add(idDiagnosticoExperto);
        }
    }
}