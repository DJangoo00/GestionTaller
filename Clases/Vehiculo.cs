using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionTaller.Clases
{
    public class Vehiculo
    {
        public int ccCliente { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }


        public Vehiculo(){}
        public Vehiculo(int ccCliente, string placa, string modelo, string marca, string color)
        {
            this.ccCliente = ccCliente;
            this.placa = placa;
            this.modelo = modelo;
            this.marca = marca;
            this.color = color;
        }
        public Vehiculo AgregarVehiculo(int ccCliente, string placa, string modelo, string marca, string color)
        {
            Vehiculo vehiculo = new Vehiculo(ccCliente, placa, modelo, marca, color);
            return vehiculo;
        }
        public void Mostrar()
        {
            Console.WriteLine(String.Format("{0,-10}|{1,-15}|{2,-15}|{3,-10}|", placa, modelo, marca, color));
        }
    }
}