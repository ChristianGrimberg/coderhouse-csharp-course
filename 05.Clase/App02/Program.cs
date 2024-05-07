namespace App02
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new("Juan", "Bida", 28123123, "bida@gmail.com", 44, "Cabildo 2668");
            Usuario usuario2 = new("Luis", "Lopez", 45123123, "luis@gmail.com", 17, "Piedras 8500");

            Console.WriteLine("El usuario 1 es mayor de edad? {0}", usuario1.EsMayorDeEdad());
            Console.WriteLine("El usuario 2 es mayor de edad? {0}", usuario2.EsMayorDeEdad());
        }
    }
}