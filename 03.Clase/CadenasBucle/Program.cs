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