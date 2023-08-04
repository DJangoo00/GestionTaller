using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
class MenuServicios
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.WriteLine("Menu del Servicio");
        Console.WriteLine("****************************************************************");
        //implementar
        Console.WriteLine("\t1. Crear Orden de servicio");
        Console.WriteLine("\t1. Vehiculos");
        Console.WriteLine("\t1. Empleados");
        Console.WriteLine("\t1. Orden de servicio");
        Console.WriteLine("\t1. Facturas");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}