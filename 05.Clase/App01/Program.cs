namespace App01
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto testProducto = new(1, "Lapiz", 3.45f, 4.5f, "Libreria");

            if (testProducto.HayPrecioDeVenta())
            {
                Console.WriteLine("{0}\n{1}", "Hay precio de venta", testProducto);
            }
            else
            {
                Console.WriteLine("El producto no fue publicado aun");
            }
        }
    }
}