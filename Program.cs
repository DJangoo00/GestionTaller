using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using GestionTaller.View;
using GestionTaller.Clases;
internal class Program
{
    public static Dictionary<int, Cliente> Clientes = new Dictionary<int, Cliente>();
    public static List<Vehiculo> Vehiculos = new List<Vehiculo>();
    public static Dictionary<int, Empleado> Empleados = new Dictionary<int, Empleado>();
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
                Cliente cliente = new Cliente(cc, nombre, celular, email, fechaRegistro);
                try
                {
                    Clientes.Add(cc, cliente);
                }
                catch
                {
                    Console.WriteLine("Error al crear cleinte!");
                }
                break;
            case 2:
                Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}", "CC", "Nombre", "Celular", "Email", "Fecha Registro"));
                Console.WriteLine("------------------------------------------------------------------------------------");
                foreach (var item in Clientes.Values)
                {
                    item.Mostrar();
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

    public static void MenuDeVehiculos()
    {
        MenuVehiculos menuVehiculos = new MenuVehiculos();
        int opcion = MenuVehiculos.Menu();
        switch (opcion)
        {
            case 1:
                /*Console.WriteLine("Ingrese el numero de identificacion: ");
                int cc = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de identificacion: ");
                string placa = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de identificacion: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de identificacion: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de identificacion: ");
                string color = Console.ReadLine();
                Vehiculo vehiculo = new Vehiculo(cc, placa, modelo, marca, color);
                Vehiculos.Add(vehiculo);*/
                break;
            case 2:
                /*Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}", "CC", "Nombre", "Celular", "Especialidad", "Activo"));
                foreach (var item in Empleados)
                {
                    item.Mostrar();
                }*/
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
                Console.WriteLine("Ingrese el numero de identificacion: ");
                int cc = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de celular: ");
                int celular = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la especialidad del empleado: ");
                string especialidad = Console.ReadLine();
                bool estado = true;
                Empleado empleado = new Empleado(cc, nombre, celular, especialidad, estado);
                try
                {
                    Empleados.Add(cc, empleado);
                }
                catch
                {
                    Console.WriteLine("Error al crear empleado!");
                }

                break;
            case 2:
                Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-20}|{4,-10}", "CC", "Nombre", "Celular", "Especialidad", "Activo"));
                Console.WriteLine("------------------------------------------------------------------------------------");
                foreach (var item in Empleados.Values)
                {
                    item.Mostrar();
                }
                break;
            case 3:
                Console.WriteLine("Ingrese el numero de identificacion: ");
                int ccBusqueda = int.Parse(Console.ReadLine());
                Empleados[ccBusqueda].CambiarEstado();
                break;
            case 4:
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

