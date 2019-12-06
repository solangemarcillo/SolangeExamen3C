using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_1
{
    class ClienteRegistrado:Cliente
    {
        public ClienteRegistrado()
        {
            this.Descuento = 0.5M;
        }
       
        public DateTime FechaInicioRegistro { get; set; }
        public DateTime FechaFinalisacion { get; set; }
        public decimal total { get; set; }
    }
}
