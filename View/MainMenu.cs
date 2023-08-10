using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
public class MainMenu
{
    public int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\t\tMenu del taller");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Clientes");
        Console.WriteLine("\t2. Vehiculos");
        Console.WriteLine("\t3. Empleados");
        Console.WriteLine("\t4. Orden de servicio");
        Console.WriteLine("\t5. Facturas");
        Console.WriteLine("\t6. Salir");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine()?? "0");
    }
}