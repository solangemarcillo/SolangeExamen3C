using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_1
{
    class ListadoClientes
    {
        public ListadoClientes()
        {
            ListaClientes = new List<Cliente>();
        }
        public List<Cliente> ListaClientes { get; set; }

        

        public Cliente ClienteSinResgistrar { get; set; }
        public Cliente ClienteRestrado { get; set; }
        public Cliente ClientePremium { get; set; }
    }
}
