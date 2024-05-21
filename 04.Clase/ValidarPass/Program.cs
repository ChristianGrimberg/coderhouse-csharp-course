bool validarContraseña(string contraseña)
{
    return contraseña.Equals("usSystem-2022");
}

string ocultarPass(string contraseña)
{
    string contraseñaOculta = String.Empty;

    foreach (char letter in contraseña)
    {
        contraseñaOculta += '*';
    }

    return contraseñaOculta;
}

void validoIngreso()
{
    int intentos = 0;
    string contraseña;
    bool ingreso = true;

    Console.Write("Ingrese la contraseña: ");


    while (ingreso)
    {
        contraseña = Console.ReadLine();
        intentos++;

        if (validarContraseña(contraseña))
        {
            string passOculto = ocultarPass(contraseña);
            Console.WriteLine("Bienvenido a CoderHouse Dev");
            Console.WriteLine("Su contraseña es correcta: {0}", passOculto);
            break;
        }
        else if (intentos >= 5)
        {
            Console.WriteLine("Su contrase no fue valida y agoto los intentos");
            break;
        }

        int restoDeIntentos = 5 - intentos;
        Console.Write("Su contrase no fue valida, le quedan {0} intentos. Pruebe nuevamente: ", restoDeIntentos);

    }
}

validoIngreso();