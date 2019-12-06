using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_1
{
    class ClientePremiun:Cliente
    {
        public ClientePremiun()
        {
            this.Descuento = 0.5M;
        }
       
        public DateTime FechaInscri { get; set; }

        public decimal FechaDeInscre()
        {
            TimeSpan timeSpan = DateTime.Today - this.FechaInscri;
            int dias = timeSpan.Days;
            int fecha = dias / 365;
            return fecha;
        }
        public decimal CalcularDescuento()
        {
          
            return this.Precio * (this.Descuento / 100);
        }
    }
}
