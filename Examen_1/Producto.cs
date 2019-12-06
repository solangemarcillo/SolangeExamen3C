using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_1
{
    class Producto
    {
        public Producto()
        {

        }
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal total { get; set; }
        public decimal CalcularDescuento()
        {
            return 0.5M;
        }
    }
}
