using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {//objeto de la clase
            clsClientesVentas Cliente;
            //instancia de la clase
            Cliente = new clsClientesVentas();

            Cliente.IdClientes = 123;
            Cliente.Apellidos = "Pon atencion";
            Cliente.Nombres = "Jose Luis";
            Cliente.RFC = "DSNMFSDF";
            Cliente.Direccion = "Inserte direccion dew Cesca";
            Cliente.Municipio = "Tijuana es un municipio :/";
            Cliente.EsCredito = true;

            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Municipio);

            if (Cliente.EsCredito)
                Console.WriteLine("El cliente tiene credito");
            else
                Console.WriteLine("El cliente no tiene credito");

            
        }
    }
}
