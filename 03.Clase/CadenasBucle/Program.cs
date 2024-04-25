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

//Console.WriteLine(cadenaNula.Length.ToString());
Console.WriteLine(cadenaVacia.Length.ToString());
Console.WriteLine(cadenaSaludo.Length.ToString());