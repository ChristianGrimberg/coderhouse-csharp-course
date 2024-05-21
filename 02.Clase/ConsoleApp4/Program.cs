// See https://aka.ms/new-console-template for more information

/*
Nos piden que armemos un programa de consola que valide la contraseña
que ingresa el usuario por teclado y nos informe qué perfil tiene el
usuario los cuales pueden ser A para Administrador, U para Usuario y
en caso contrario Sin Perfil definido.
 
Tener en cuenta que la contraseña debe estar almacenada previamente
al momento de la ejecución del programa. Es “numérica” de ocho dígitos.
Así como también el perfil preestablecido que puede ser A, U o X.

Si el acceso es válido, mostrar un mensaje de bienvenida y el perfil
del usuario. De lo contrario, se le pide una vez más la contraseña.
Si el acceso es válido esta última vez, también mostrar un mensaje
de bienvenida. De lo contrario, informar que debe reiniciar el sistema.
*/

// Variable
int pass = 123456789;
int passIngresado;
string perfilIngresado;

Console.Write("Ingrese su perfil: ");
perfilIngresado = Console.ReadLine();

Console.Write("Ingrese su contraseña: ");
passIngresado = Convert.ToInt32(Console.ReadLine());

if (passIngresado == pass)
{
    switch (perfilIngresado)
    {
        case "A":
            Console.WriteLine("Bienvenido Administrador");
            break;
        case "U":
            Console.WriteLine("Bienvenido Usuario");
            break;
        default:
            Console.WriteLine("Bienvenido. Sin perfil definido");
            break;
    }
}
else
{
    Console.WriteLine("DEBE REINICIAR EL SISTEMA");
}