using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
class MainMenu
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.WriteLine("Menu del taller");
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Clientes");
        Console.WriteLine("\t2. Vehiculos");
        Console.WriteLine("\t3. Empleados");
        Console.WriteLine("\t4. Orden de servicio");
        Console.WriteLine("\t5. Facturas");
        Console.WriteLine("\t6. Salir");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}