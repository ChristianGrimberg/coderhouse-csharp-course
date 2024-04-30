int numero1;
int numero2;

int sumar(int num1, int num2)
{
    return num1 + num2;
}

Console.Write("Ingrese el primer numero: ");
numero1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
numero2 = int.Parse(Console.ReadLine());

int total = sumar(numero1, numero2);

Console.WriteLine("El total de la suma es: {0}", total);