int precioCodigo(string codigo)
{
    int precio = 0;

    switch (codigo)
    {
        case "DES":
            precio = 200;
            break;
        case "JP":
            precio = 300;
            break;
        case "DET":
            precio = 250;
            break;
        default:
            Console.WriteLine("El codigo {0} no existe.", codigo);
            break;
    }

    return precio;
}

void venta()
{
    string codigo = String.Empty;
    int cantProductos;
    int montoAPagar = 0;
    string confirmacion = string.Empty;

    Console.WriteLine("Bienvenidos, estos son nuestros productos\n");
    Console.WriteLine("Código\tDescripcion\tPrecio");
    Console.WriteLine("DES\tDesorante\t200");
    Console.WriteLine("JP\tJabon en polvo\t300");
    Console.WriteLine("DET\tDetergente\t250");

    while (codigo != "FIN")
    {
        Console.Write("Ingrese el codigo que desee comprar: ");
        codigo = Console.ReadLine().ToUpper();

        if(codigo == "FIN") break;

        Console.Write("Ingrese la cantidad que desee comprar: ");
        cantProductos = int.Parse(Console.ReadLine());

        Console.Write("Desea comprarlo? Ingrese SI para aceptar: ");
        confirmacion = Console.ReadLine().ToUpper();

        if(confirmacion == "SI") montoAPagar += (cantProductos * precioCodigo(codigo));

        Console.WriteLine("Su monto a pagar es {0}", montoAPagar);
    }
}

venta();