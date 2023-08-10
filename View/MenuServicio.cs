using System.Collections.Generic;
using System.Linq;
namespace GestionTaller.View;
class MenuServicios
{
    public static int Menu()
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Menu del Servicio");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("****************************************************************");
        Console.WriteLine("\t1. Ingresar vehiculo a servicio");
        Console.WriteLine("\t2. Agregar Diagnostico Experto");
        Console.WriteLine("\t3. Mostrar Orden de Servicios por ID de Orden");
        Console.WriteLine("\t4. Mostrar Ordenes de Servicios por id de Cliente");
        Console.WriteLine("\t5. Agregar Repuestos");
        Console.WriteLine("\t6. Mostrar Orden y repuestos");
        Console.WriteLine("\t7. Aprobar Orden y repuestos");
        Console.WriteLine("\t8. Volver al menu principal");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}