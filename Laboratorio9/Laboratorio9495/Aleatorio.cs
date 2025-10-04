using System;

class Aleatorio
{
    private Random rnd;

    
    public Aleatorio()
    {
        rnd = new Random();
    }

    
    public int GenerarNumero(int min, int max)
    {
        return rnd.Next(min, max + 1); 
    }

    
    public int[] GenerarArreglo(int cantidad, int min, int max)
    {
        int[] arreglo = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = GenerarNumero(min, max);
        }

        return arreglo;
    }
}
