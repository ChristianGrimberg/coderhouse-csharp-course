string cadenaNula = null;
string cadenaVacia = String.Empty;
string cadenaSaludo = "Hola, soy una cadena...";

Console.WriteLine(cadenaSaludo + cadenaNula + cadenaVacia);

if(cadenaVacia == cadenaNula)
{
    Console.WriteLine("Las cadenas son iguales!");
}
else
{
    Console.WriteLine("Las cadenas no son iguales");
}

Console.ReadKey();