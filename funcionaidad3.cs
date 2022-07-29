class funcionalidad3: funcionalidadDecorador
{
    public funcionalidad3(OrdenBase orden) : base(orden)
    {

    }

    public override double CalcularDispositivoReparar()
    {
        return base.CalcularDispositivoReparar() + 50;
    }
}