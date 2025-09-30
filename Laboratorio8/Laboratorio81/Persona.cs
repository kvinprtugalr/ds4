using System;

class Persona
{
    //Campo de cada obejto Persona que almacena su nombre
    public string Nombre;
    //Campor de cada obeto Persona que almacena su edad
    public int Edad;
    //Campor de cada objeto persona que almacena su NIF
    public string Nif;

    void Cumpleaños() //Incrementa en uno de edad del objeto Persona
    {
        Edad++;
    }

    //Constructor Persona
    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        Nif = nif;
    }

  
}