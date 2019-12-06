using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_1
{
    class StockProductos
    {
        public StockProductos()
        {
            StockProducto = new List<Producto>();
        }
        public List<Producto> StockProducto { get; set; }

        public void GeneraProductos()
        {
            Random random = new Random();
            int numero;
            decimal total = 0;



          
          
            for (int i = 1; i <= 10; i++)
            {
                
                Cliente cliente = new Cliente();
                Producto producto = new Producto();
                ClientePremiun clienteprimium = new ClientePremiun();
                producto.Codigo = i;
                numero = random.Next(20);
                char letraprimium = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "Producto " + letraprimium;
                producto.Precio = Decimal.Parse(random.Next(10).ToString());
                producto.Descuento = 0.5M;
                total = total + numero;
                clienteprimium.FechaInscri = new DateTime(10 / 10 / 2004);
                StockProducto.Add(producto);


            }


        }
        public void imprimirlistado()
        {
            Console.WriteLine("Stock De Productos");
            Console.WriteLine("\tIdentificador\t\t\tDescripcion\t\t\tPrecio\t\t\tDescuento");
            foreach (var item in StockProducto)
            {
                Console.WriteLine("\t\t{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}",
                item.Codigo, item.Descripcion, item.Precio, item.Descuento);
            }

        }
    }
}
