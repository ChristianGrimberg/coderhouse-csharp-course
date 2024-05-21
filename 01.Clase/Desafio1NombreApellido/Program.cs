namespace Desafio1NombreApellido;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo 1
        Console.WriteLine("Bienvenidos!");

        string nombre;
        nombre = "Christian";

        Console.WriteLine("Mi nombre es: {0}", nombre);

        string apellido = "Grimberg";

        Console.WriteLine("Mi apellido es: {0}", apellido);

        const int dni = 123456789;

        Console.WriteLine("Mi DNI es: {0}", dni);

        // Ejemplo 2
        int number1;
        int number2;

        Console.Write("Ingrese el primer numero a sumar: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo numero a sumar: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        int total = number1 + number2;
        Console.WriteLine("El total de la suma es: {0}", total);

        // Ejemplo 3
        Console.WriteLine("Mi nombre es {0} {1} {2}", nombre, "stui", apellido);
        Console.WriteLine($"Mi nombre es {nombre} \"stui\" {apellido}");

        Console.Write("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
