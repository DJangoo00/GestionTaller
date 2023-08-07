using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using GestionTaller.View;
using GestionTaller.Clases;
internal class Program
{
    public static List<Cliente> Clientes = new List<Cliente>();
    public static List<Vehiculo> Vehiculos = new List<Vehiculo>();
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
                    MenuDeVehiculos();
                    break;
                case 3:
                    MenuDeEmpleados();
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
                Console.WriteLine("Ingrese el numero de identificacion: ");
                int cc = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de celular: ");
                int celular = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de registro: ");
                string fechaRegistro = Console.ReadLine();
                Cliente cliente = new Cliente(cc,nombre, celular, email, fechaRegistro);
                Clientes.Add(cliente);
                break;
            case 2:
                Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}","CC", "Nombre", "Celular", "Email", "Fecha Registro"));
                foreach (var item in Clientes)
                {
                    Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}",item.cc, item.nombre, item.celular, item.email, item.fechaRegistro));
                }
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

