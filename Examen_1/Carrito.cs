using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_1
{
    class Carrito
    {
        public Carrito()
        {
            this.Detalle = new List<Detalledelcarrito>();
        }
        public ListadoClientes Cabecera { get; set; }


        public List<Detalledelcarrito> Detalle { get; set; }


    }
}
