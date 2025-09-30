using System;

class Cuenta
{
    private string idCuenta;

    
    public Cuenta(string prmtIdCuenta)
    {
        this.idCuenta  = prmtIdCuenta;
        Console.WriteLine("Constructor Clase Base para cuenta {0}", prmtIdCuenta);

    }

    public virtual void CalcularIntereses()
    {
        Console.WriteLine("Cuenta.CalcularInteres() efectuado para la cuenta {0}", this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}
