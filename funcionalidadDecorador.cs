class funcionalidadDecorador : OrdenBase
{
    protected OrdenBase orden;
    public funcionalidadDecorador(OrdenBase orden) 
    {
        this.orden = orden;
    }

    public virtual double CalcularTotalPrecio()
    {
        Console.WriteLine("Precio Calculado desde el decorador");
        return orden.CalcularTotalPrecio();
    }
}