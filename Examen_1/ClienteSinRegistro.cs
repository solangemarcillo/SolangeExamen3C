using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_1
{
    class ClienteSinRegistro:Cliente
    {
        public ClienteSinRegistro()
        {
            this.Descuento = 0.5M;
        }
        //public decimal Descuento { get; set; }
        public string Telefono { get; set; }



        public decimal CalcularDescuento()
        {
            //procesos
            return this.Precio * (this.Descuento / 100);

        }


    }
}
