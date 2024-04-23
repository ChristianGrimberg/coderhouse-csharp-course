// See https://aka.ms/new-console-template for more information

/*
La secretaria de una universidad nos pide un sistema para poder
cargar los datos de sus alumnos, necesitan poder cargar la comisión
que puede ser A si son de turno mañana, B si son de turno tarde,
C si son de turno noche y en caso de no tener comisión indica
que no tienen turno fijado.

También cada docente califica a sus alumnos con una nota entre
0 y 10, en caso de ser menor a 4 el alumno Recursa la Materia,
si está entre 4 y 7 es Aprobó Cursada y si es mayor que 7
Promociona la Materia..
*/

string comision;
int calificacion;

Console.WriteLine("BIENVENIDOS A LA UNIVERSIDAD CODERHOUSE");
Console.Write("INGRESE SU COMISION: ");
comision = Console.ReadLine();

switch (comision)
{
    case "A":
        Console.WriteLine("Turno Mañana");
        break;
    case "B":
        Console.WriteLine("Turno Tarde");
        break;
    case "C":
        Console.WriteLine("Turno Noche");
        break;
    default:
        Console.WriteLine("Sin turno fijo");
        break;
}

Console.Write("Ingrese la nota del alumno: ");
calificacion = Convert.ToInt32(Console.ReadLine());

if(calificacion >= 0 && calificacion < 4)
{
    Console.WriteLine("Recursa");
}
else
{
    if(calificacion >= 4 && calificacion <= 7)
    {
        Console.WriteLine("Aprobo la cursada");
    }
    else
    {
        if(calificacion > 7 && calificacion <= 10)
        {
            Console.WriteLine("Promociono la materia");
        }
        else
        {
            Console.WriteLine("Calificar solo del 0 al 10");
        }
    }
}
