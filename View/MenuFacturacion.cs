using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
class MenuFacturacion
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Menu de Facturacion");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Crear Factura");
        Console.WriteLine("\t2. Volver al menu principal");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}