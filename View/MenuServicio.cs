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
        Console.WriteLine("\t1. Ingresar vehiculo a servicio");
        Console.WriteLine("\t2. Agregar Diagnostico Experto");
        Console.WriteLine("\t3. Agregar Repuesto");
        Console.WriteLine("\t4. Agregar Orden de Aprobacion");
        Console.WriteLine("\t5. Volver al menu principal");
        Console.WriteLine("****************************************************************");
        Console.Write("\tSeleccione una opcion: ");
        return int.Parse(Console.ReadLine());
    }
}