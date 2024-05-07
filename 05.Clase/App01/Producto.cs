namespace App01;

public class Producto
{
    // sin setter ni getters

    public int Codigo { get; set; }
    public string Descripcion { get; set; }
    public double PrecioDeCompra { get; set; }
    public double PrecioDeVenta { get; set; }

    private string categoria;
    public string Categoria
    {
        get
        {
            if(!string.IsNullOrEmpty(categoria)) return this.categoria;
            else return "Sin categoria";
        }
    }

    public Producto()
    {
        this.Codigo = 0;
        this.Descripcion = string.Empty;
        this.PrecioDeCompra = 0;
        this.PrecioDeVenta = 0;
        this.categoria = string.Empty;

        Console.WriteLine("Se inicializo el contructor por defecto");
    }

    public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeVenta, string categoria)
    {
        this.Codigo = codigo;
        this.Descripcion = descripcion;
        this.PrecioDeCompra = precioDeCompra;
        this.PrecioDeVenta = precioDeVenta;
        this.categoria = descripcion;

        Console.WriteLine("Se inicializo el constructor sobrecargado");
    }

    public bool HayPrecioDeVenta()
    {
        return this.PrecioDeVenta > 0;
    }

    public override string ToString()
    {
        string retorno = string.Empty;

        retorno += String.Format("El valor de {0} es {1}\n", "Codigo", this.Codigo.ToString());
        retorno += String.Format("El valor de {0} es {1}\n", "Descripcion", this.Descripcion);
        retorno += String.Format("El valor de {0} es {1:0.00}\n", "PrecioDeCompra", this.PrecioDeCompra);
        retorno += String.Format("El valor de {0} es {1:0.00}\n", "PrecioDeVenta", this.PrecioDeVenta);
        retorno += String.Format("El valor de {0} es {1}\n", "Categoria", this.categoria);

        return retorno;
    }
}
