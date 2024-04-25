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

string mensaje = "Voy a desarrolllar en C#";

Console.WriteLine("Mensaje en minusculas: {0}", mensaje.ToLower());
Console.WriteLine("Mensaje en mayusculas: {0}", mensaje.ToUpper());

int numeroEntero = 22;
double numeroConDecimales = 1.88;
bool booleano = true;

Console.WriteLine("La edad de Luis es: {0}, {1}, {2}", numeroEntero.ToString(), numeroConDecimales.ToString(), booleano.ToString());

string cadena1 = "Soy una cadena ";
string cadena2 = "Soy una cadena";

if(cadena1.Equals(cadena2))
{
    Console.WriteLine("Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas no son iguales");
}

if(cadena1.Contains(cadena2))
{
    Console.WriteLine("Las cadena 1 contiene a cadena 2");
}
else
{
    Console.WriteLine("La cadena 1 no contiene a cadena 2");
}