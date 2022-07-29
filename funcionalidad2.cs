lass funcionalidad2: funcionalidadDecorador
{
    public funcionalidad2(OrdenBase orden) : base(orden)
    {

    }

    public override double CalcularDispositivoReparar()
    {
        return base.CalcularDispositivoReparar() + 30;
    }
}