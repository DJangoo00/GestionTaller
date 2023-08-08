using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
public class MenuClientes
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Menu de Clientes");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Agregar Cliente");
        Console.WriteLine("\t2. Listar Clientes");
        Console.WriteLine("\t3. Regresar al menu principal");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}