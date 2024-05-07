namespace App01
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto testProducto = new Producto(1, "Lapiz", 3.45f, 0, "Libreria");
            
            if(testProducto.hayPrecioDeVenta())
            {
                Console.WriteLine("{0}\n{1}","Hay precio de venta", testProducto);
            }
            else
            {
                Console.WriteLine("El producto no fue publicado aun");
            }
        }
    }
}