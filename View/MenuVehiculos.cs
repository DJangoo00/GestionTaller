using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
class MenuVehiculos
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Menu de Vehiculos");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Agregar Vehiculo");
        Console.WriteLine("\t2. Listar Vehiculos por cliente");
        Console.WriteLine("\t3. Regresar al menu principal");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}