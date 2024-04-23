// See https://aka.ms/new-console-template for more information

/*
Supongamos que tenemos un listado de Empleados y queremos mostrar a qué categoría
corresponden según su código a saber:

A es Administrativo
B es Profesional
C es Maestranza
Ninguno de los anteriores es Sin Categoria

Observar el uso de ReadLine() en este caso al asignarse a una variable string no
fue necesario convertir.
*/

string categoria;

Console.Write("Ingrese la categoria A, B, C o D: ");
categoria = Console.ReadLine();

if(String.IsNullOrWhiteSpace(categoria))
{
    switch (categoria)
    {
        case "A":
        case "D":
            Console.WriteLine("Empleado Administrativo");
            break;
        case "B":
            Console.WriteLine("Empleado Profesional");
            break;
        case "C":
            Console.WriteLine("Empleado Maestranza");
            break;
        default:
            Console.WriteLine("Sin categoria");
            break;
    }
}
else
{
    Console.WriteLine("Sin valor");
}
