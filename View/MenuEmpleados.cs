using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
class MenuEmpleados
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Menu de Empleados");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Agregar Empleado");
        Console.WriteLine("\t2. Listar Empleados");
        Console.WriteLine("\t3. Cambiar estado empleado");
        Console.WriteLine("\t4. Regresar al menu principal");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}