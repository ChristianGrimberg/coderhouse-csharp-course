namespace App02;

public class Usuario
{
    private string nombre;
    private string apellido;
    private int dni;
    private string mail;
    private int edad;
    private string domicilio;

    public string Nombre { get => nombre; }
    public string Apellido { get => apellido; }
    public int DNI { get => dni; }
    public string Mail { get => mail; set => mail = value; }
    public int Edad { get => edad; }
    public string Domicilio { get => domicilio; }

    public Usuario(string _nombre, string _apellido, int _dni, string _mail, int _edad, string _dominicio)
    {
        this.nombre = _nombre;
        this.apellido = _apellido;
        this.dni = _dni;
        this.mail = _mail;
        this.edad = _edad;
        this.domicilio = _dominicio;
    }

    public bool EsMayorDeEdad()
    {
        return this.Edad >= 18;
    }
}
