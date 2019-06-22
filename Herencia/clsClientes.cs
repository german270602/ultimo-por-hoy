using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class clsClientes
    {
        private int _IdClientes;

        private string _Nombres;

        private string _Apellidos;
        //encapsulado realizado usando las teclas "ctrl"+"R"+"E"
        public int IdClientes { get => _IdClientes; set => _IdClientes = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
    }
}
