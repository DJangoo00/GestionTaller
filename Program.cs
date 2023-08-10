using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using GestionTaller.View;
using GestionTaller.Clases;
internal class Program
{
    public static Dictionary<int, Cliente> Clientes = new();
    public static Dictionary<string, Vehiculo> Vehiculos = new Dictionary<string, Vehiculo>();
    public static Dictionary<int, Empleado> Empleados = new Dictionary<int, Empleado>();
    public static Dictionary<int, OrdenServicio> Servicios = new Dictionary<int, OrdenServicio>();
    public static Dictionary<int, DiagnosticoExperto> DiagnosticosExpertos = new Dictionary<int, DiagnosticoExperto>();
    public static Dictionary<int, Repuesto> Repuestos = new Dictionary<int, Repuesto>();
    public static Dictionary<int, OrdenAprobacion> OrdenesAprobacion = new Dictionary<int, OrdenAprobacion>();

    public static void Main(string[] args)
    {
        MainMenu menu = new MainMenu();
        int? opcion;
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
                Vehiculo vehiculo = new Vehiculo();
                Console.WriteLine("Ingrese el numero de identificacion: ");
                int ccCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la placa del vehiculo: ");
                string placa = Console.ReadLine();
                Console.WriteLine("Ingrese el mdoelo del vehiculo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Ingrese la marca del vehiculo: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Ingrese el color del vehiculo: ");
                string color = Console.ReadLine();
                try
                {
                    Vehiculos.Add(placa, vehiculo.AgregarVehiculo(ccCliente, placa, modelo, marca, color));
                }
                catch
                {
                    Console.WriteLine("Error al ingresar vehiculo!");
                }
                break;
            case 2:
                Console.WriteLine("Ingrese el numero de identificacion del cliente: ");
                int ccBusqueda = int.Parse(Console.ReadLine());
                Console.WriteLine(String.Format("{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}", "CC", "Nombre", "Celular", "Email", "Fecha Registro"));
                Clientes[ccBusqueda].Mostrar();
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine(String.Format("{0,-10}|{1,-15}|{2,-15}|{3,-10}|", "Placa", "Modelo", "Marca", "Color"));
                Console.WriteLine("------------------------------------------------------------------------------------");
                foreach (var item in Vehiculos.Values)
                {
                    if (item.ccCliente == ccBusqueda)
                    {
                        item.Mostrar();
                    }
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
    //Clase de orden de servicios en implementacion
    {
        MenuServicios menuServicios = new MenuServicios();
        int opcion = MenuServicios.Menu();
        switch (opcion)
        {
            case 1:
                OrdenServicio ordenServicio = new OrdenServicio();
                int idOrden = Servicios.Count + 1;
                Console.WriteLine("Ingrese el numero de identificacion del cliente: ");
                int ccCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de identificacion del empleado a cargo: ");
                int ccEmpleado = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de ingreso: ");
                string fechaOrden = Console.ReadLine();
                Console.WriteLine("Ingrese la placa del vehiculo: ");
                string placa = Console.ReadLine();
                Console.WriteLine("Ingrese el kilometraje de ingreso: ");
                int km = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el diagnostico del cliente: ");
                string diagnosticoCliente = Console.ReadLine();
                try
                {
                    Servicios.Add(idOrden, ordenServicio.AgregarServicio(idOrden, ccCliente, ccEmpleado, fechaOrden, placa, km, diagnosticoCliente));
                }
                catch
                {
                    Console.WriteLine("Error al ingresar Orden de servicio!");
                }
                break;
            case 2:
                //corregir error no agregar diagnostico experto
                Console.WriteLine("Ingrese el numero de orden de servicio: ");
                int idOrdenBusqueda = int.Parse(Console.ReadLine());
                DiagnosticoExperto diagnosticoExperto = new DiagnosticoExperto();
                int idDiagnostico = DiagnosticosExpertos.Count + 1;
                Console.WriteLine("Ingrese el numero de identificacion: ");
                string diagnostico = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de identificacion del empleado: ");
                int ccEmpleadoDiag = int.Parse(Console.ReadLine());
                try
                {
                    var diagnosticoAct = diagnosticoExperto.AgregarDiagnostico(idDiagnostico, diagnostico, ccEmpleadoDiag);
                    Servicios[idOrdenBusqueda].AgregarDiagnostico(diagnosticoAct.idDiagnosticoExperto);

                    DiagnosticosExpertos.Add(idDiagnostico, diagnosticoAct);
                }
                catch
                {
                    Console.WriteLine("Error al ingresar Orden de servicio!");
                }
                break;
            case 3:
                Console.WriteLine("Orden de servicio:");
                Console.WriteLine("Ingrese el numero de orden de servicio: ");
                int idOrdenBusqueda2 = int.Parse(Console.ReadLine());
                Servicios[idOrdenBusqueda2].mostrarServicio();
                break;
            case 4:
                Console.WriteLine("ORden de servicio:");
                Console.WriteLine("Ingrese el documento del cliente: ");
                int idClientBusqueda = int.Parse(Console.ReadLine());
                foreach (var item in Servicios.Values)
                {
                    if (item.ccCliente == idClientBusqueda)
                    {
                        item.mostrarServicio();
                    }
                }
                break;
            case 5:
                //DAta orden aprobacion 
                int newIdAprobacion = Repuestos.Count + 1;
                OrdenAprobacion ordenAprobacion = new OrdenAprobacion();
                Console.WriteLine("Ingrese el id de la orden de servicio correspondiente: ");
                int idOrdenServicio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la identificacion del empleado: ");
                int ccEmpleadoOrden = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de la orden de aprobacion: ");
                string fechaDeOrden = Console.ReadLine();
                try
                {
                    OrdenesAprobacion.Add(newIdAprobacion, ordenAprobacion.AgregarOrden(idOrdenServicio, ccEmpleadoOrden, fechaDeOrden));
                }
                catch
                {
                    Console.WriteLine("Error al crear orden de aprobacion!");
                }
                //Data Repuesto
                string Opcion;
                do
                {
                    int idRepuesto = Repuestos.Count + 1;
                    Repuesto repuesto = new Repuesto();
                    Console.WriteLine("Ingrese el nombre del repuesto: ");
                    string nombreRepuesto = Console.ReadLine();
                    Console.WriteLine("Ingrese el valor individual del repuesto: ");
                    int valorRepuesto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad del repuesto: ");
                    int CantidadRepuesto = int.Parse(Console.ReadLine());
                    int TotalRepuesto = CantidadRepuesto * valorRepuesto;
                    try
                    {
                        Repuestos.Add(idRepuesto, repuesto.AgregarRepuesto(nombreRepuesto, valorRepuesto, CantidadRepuesto, TotalRepuesto));
                        Console.WriteLine("Repuesto Listado con exito");//lineaprueba
                        Console.WriteLine("{0},{1}","prueba id aprobacion",newIdAprobacion);//lineaprueba
                        OrdenesAprobacion[newIdAprobacion].AgregarIdRepuesto(idRepuesto);//error al ingresar
                        Console.WriteLine("Repuesto agregado a orden de aprobacion");//lineaprueba
                    }
                    catch
                    {
                        Console.WriteLine("Error al ingresar repuesto");
                    }
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("Desea agregar otro repuesto? (y/n): ");
                    Opcion = Console.ReadLine();
                } while (Opcion == "y");
                break;
            case 6:
                Console.WriteLine("Ingrese el numero de Orden de Aprobacion: ");
                int idOrdenAprobacionBusqueda = int.Parse(Console.ReadLine());
                if (OrdenesAprobacion.ContainsKey(idOrdenAprobacionBusqueda))
                {
                    OrdenesAprobacion[idOrdenAprobacionBusqueda].MostrarDetalle();
                    try
                    {
                        foreach (var item in OrdenesAprobacion[idOrdenAprobacionBusqueda].listRepuestos)
                        {
                            Repuestos[item].MostrarRepuesto();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("La orden de aprobacion no contiene repuestos!");
                    }
                }
                else
                {
                    Console.WriteLine("No se ha encontrado la orden");
                }
                break;
            case 7:
                Console.WriteLine("Ingrese el numero de Orden de Aprobacion: ");
                int idOrdenAprobacion = int.Parse(Console.ReadLine());
                if (OrdenesAprobacion.ContainsKey(idOrdenAprobacion))
                {
                    OrdenesAprobacion[idOrdenAprobacion].MostrarAprobacion();
                    try
                    {
                        foreach (var item in OrdenesAprobacion[idOrdenAprobacion].listRepuestos)
                        {
                            Repuestos[item].MostrarRepuesto();
                            Repuestos[item].CambiarEstado();
                        }
                        OrdenesAprobacion[idOrdenAprobacion].CambiarEstado();
                    }
                    catch
                    {
                        Console.WriteLine("La orden de aprobacion no contiene repuestos!");
                    }
                }
                else
                {
                    Console.WriteLine("No se ha encontrado la orden");
                }
                break;
            case 8:
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