using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using GestionTaller.View;
using GestionTaller.Clases;
internal class Program
{
    public static void Main(string[] args)
    {
        MainMenu menu = new MainMenu();
        int opcion;
        do
        {
            opcion = menu.Menu();
            switch (opcion)
            {
                case 1:
                    MenuDeClientes();
                    break;
                case 2:
                    MenuDeEmpleados();
                    break;
                case 3:
                    MenuDeVehiculos();
                    break;
                case 4:
                    MenuDeServicios();
                    break;
                case 5:
                    MenuDeFacturacion();
                    break;
                case 6:
                    Console.WriteLine("Saliendo!");
                    break;
                default:
                    Console.WriteLine("Opcion invalida!");
                    break;
            }
        } while (opcion != 6);
    }
    static void PressCont()
    {
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadLine();
    }
    public static void MenuDeClientes()
    {
        MenuClientes menuClientes = new MenuClientes();
        int opcion = MenuClientes.Menu();
        switch (opcion)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Opcion invalida!");
                break;
        }
        PressCont();
    }
    static void MenuDeEmpleados()
    {
        MenuEmpleados menuEmpleados = new MenuEmpleados();
        int opcion = MenuEmpleados.Menu();
        switch (opcion)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Opcion invalida!");
                break;
        }
        PressCont();
    }
    static void MenuDeVehiculos()
    {
        MenuVehiculos menuVehiculos = new MenuVehiculos();
        int opcion = MenuVehiculos.Menu();
        switch (opcion)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Opcion invalida!");
                break;
        }
        PressCont();
    }
    static void MenuDeServicios()
    {
        MenuServicios menuServicios = new MenuServicios();
        int opcion = MenuServicios.Menu();
        switch (opcion)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Opcion invalida!");
                break;
        }
        PressCont();
    }
    static void MenuDeFacturacion()
    {
        MenuFacturacion menuFacturacion = new MenuFacturacion();
        int opcion = MenuFacturacion.Menu();
        switch (opcion)
        {
            case 1:
                break;
            case 2:
                break;
            default:
                Console.WriteLine("Opcion invalida!");
                break;
        }
        PressCont();
    }

}

