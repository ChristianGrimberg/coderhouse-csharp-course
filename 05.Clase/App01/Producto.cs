namespace App01;

public class Producto
{
    // sin setter ni getters
    private int _codigo;
    private string _descripcion;
    private double _precioDeCompra;
    private double _precioDeVenta;
    private string _categoria;

    public Producto()
    {
        _codigo = 0;
        _descripcion = string.Empty;
        _precioDeCompra = 0;
        _precioDeVenta = 0;
        _categoria = string.Empty;

        Console.WriteLine("Se inicializo el contructor por defecto");
    }

    public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeVenta, string categoria)
    {
        this._codigo = codigo;
        this._descripcion = descripcion;
        this._precioDeCompra = precioDeCompra;
        this._precioDeVenta = precioDeVenta;
        this._categoria = categoria;

        Console.WriteLine("Se inicializo el constructor sobrecargado");
    }

    public bool hayPrecioDeVenta()
    {
        return this._precioDeVenta > 0;
    }

    public override string ToString()
    {
        string retorno = string.Empty;

        retorno += String.Format("El valor de {0} es {1}\n", "_codigo", _codigo);
        retorno += String.Format("El valor de {0} es {1}\n", "_descripcion", _descripcion);
        retorno += String.Format("El valor de {0} es {1:0.00}\n", "_precioDeCompra", _precioDeCompra);
        retorno += String.Format("El valor de {0} es {1:0.00}\n", "_precioDeVenta", _precioDeVenta);
        retorno += String.Format("El valor de {0} es {1}\n", "_categoria", _categoria);

        return retorno;
    }
}
