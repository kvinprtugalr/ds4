using System;
using System.Globalization;

abstract class ClaseAbstracta
{
    //Se fuerza la herencia de la clase para definir estos metodos
    abstract protected string tomarValor();
    abstract public string prefixValor(string prefix);
    //Metodo comun
    public void printOut()
    {
        Console.WriteLine(tomarValor());
    }

}
