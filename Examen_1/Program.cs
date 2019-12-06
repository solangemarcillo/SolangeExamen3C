using System;

namespace Examen_1
{
    class Program
    {
        static void Main(string[] args)
        {


            StockProductos stock = new StockProductos();

            stock.GeneraProductos();
            stock.imprimirlistado();
            Cliente cliente = new Cliente();
            cliente.Cedula = "1311540353";
            cliente.Nombres = "solange";
            cliente.Apellido = "marcillo";
            cliente.Email = "svmarcillo@gmail.com";
            cliente.Contrasenia = "156732";


            ListadoClientes listado = new ListadoClientes();
            listado.ClientePremium = cliente;
            listado.ClienteRestrado = cliente;
            listado.ClienteSinResgistrar = cliente;

            string opcion;


            Carrito carrito = new Carrito();

            decimal subtotal = 0;
            decimal total = 0;



            do
            {
                Console.WriteLine("Ingrese el codigo del producto");
                int codigo = int.Parse(Console.ReadLine());

                Detalledelcarrito detalledelcarrito = new Detalledelcarrito();

                detalledelcarrito.ProductoCarrito = stock.StockProducto[codigo - 0];

                Console.WriteLine("Ingrese la cantidad del producto");

                int cantidadcarro = int.Parse(Console.ReadLine());

                detalledelcarrito.Cantidad = cantidadcarro;
                total = total + (cantidadcarro * detalledelcarrito.ProductoCarrito.Precio);
                subtotal = subtotal + cantidadcarro * detalledelcarrito.ProductoCarrito.Precio;

                carrito.Detalle.Add(detalledelcarrito);

                Console.WriteLine("Escriba n seguir agregrandio productus s para salir");
                opcion = Console.ReadLine();


            } while (opcion != "s");

            Console.WriteLine("------------------Productos comprados----------------------");
            Console.WriteLine("Productos -----------Cantidad--------Precio-----------Descuento");



            foreach (var item in carrito.Detalle)
            {


                ClientePremiun clientePrimium = new ClientePremiun();
                Console.WriteLine("{0}{1}\t\t{2}\t\t{3}\t\t{4}",
                    item.ProductoCarrito.Codigo, item.ProductoCarrito.Descripcion, item.Cantidad, item.ProductoCarrito.Precio, item.ProductoCarrito.Descuento);
                Console.WriteLine("SUBTOTAL:   " + item.ProductoCarrito.Precio * item.Cantidad);
                Console.WriteLine("EL SUBTOTAL - DESCUENTO :    " + (((item.ProductoCarrito.Precio * item.Cantidad) * item.ProductoCarrito.CalcularDescuento())  - item.ProductoCarrito.Iva));
                Console.WriteLine("IVA%:  " + (item.Cantidad * item.ProductoCarrito.Descuento));
                Console.WriteLine("TOTAL:    " + ((item.ProductoCarrito.Precio * item.Cantidad) - item.ProductoCarrito.CalcularDescuento()));
            }
            foreach (var item in carrito.Detalle)
            {

                Console.WriteLine("------------------total factura----------------------");
                Console.WriteLine("SUBTOTAL^:   " + (subtotal));
                Console.WriteLine("TOTAL:   " + (total));


                Console.ReadKey();
            }
        }
    }
    
}
