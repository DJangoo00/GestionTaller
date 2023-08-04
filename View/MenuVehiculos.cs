using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
class MenuVehiculos
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.WriteLine("Menu de Vehiculos");
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Agregar Vehiculo");
        Console.WriteLine("\t2. Listar Vehiculos por cliente");
        Console.WriteLine("\t4. Regresar al menu principal");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}