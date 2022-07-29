class funcionalidad1: funcionalidadDecorador
{
    public funcionalidad1(OrdenBase orden) : base(orden)
    {

    }

    public override double CalcularDispositivoReparar()
    {
        return base.CalcularDispositivoReparar() + 20;
    }
}