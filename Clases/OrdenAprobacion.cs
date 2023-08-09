using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class OrdenAprobacion
    {
        public int idOrdenServicio { get; set; }
        public int ccEmpleado { get; set; }
        public string fecha { get; set; }
        public bool aprobada { get; set; }
        public List<int> listRepuestos { get; set; }

        public OrdenAprobacion(){}
        public OrdenAprobacion (int idOrdenServicio, int ccEmpleado, string fecha)
        {
            this.idOrdenServicio = idOrdenServicio;
            this.ccEmpleado = ccEmpleado;
            this.fecha = fecha;
            this.aprobada = false;
        }
        public void AgregarIdRepuesto(int idRepuesto)
        {
            listRepuestos.Add(idRepuesto);
        }
        public OrdenAprobacion AgregarOrden(int idOrdenServicio, int ccEmpleado, string fecha)
        {
            OrdenAprobacion ordenAprobacion = new OrdenAprobacion(idOrdenServicio, ccEmpleado, fecha);
            return ordenAprobacion;
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
                    aprobada = true;
                    break;
                case 2:
                    aprobada = false;
                    break;
                default:
                Console.WriteLine("Opcion Invalida");
                    break;
            }
        }
        public void MostrarAprobacion()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(String.Format("{0,-30}{1,30}", "Numero de Orden:",idOrdenServicio));
            Console.WriteLine(String.Format("{0,-30}{1,30}", "Fecha de Orden:",fecha));
            Console.WriteLine(String.Format("{0,-30}{1,30}", "Identificacion del Empleado:",ccEmpleado));
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("--------------------Detalle de Aprobacion-------------------");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
    
}