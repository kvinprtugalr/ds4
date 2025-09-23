//Declaracion erronea
using System.Runtime.Serialization.Formatters;

int valores[];
//Declaracion valida
int[] valores;


int[] valores; // valores sin inicializar
valores = new int[100]; // 100 elementos 
valores = new int[20]; //ahora contiene 20 elementos

//Arreglos unidimensionales o de dimension simple

int[] valores1;
int[] valores2 = new int[50];

//Arreglos multidimensionales
int[,] valores1;
int[,] valores2 = new int[3,7];
int[,,] valores3; new int[3, 4, 2]; //Arreglo de tres dimensiones

//Arreglo de arreglos
int[][] matriz;  // sin inicializar
//Los arreglos de arreglos se inicializan de manera diferente
int[][] matriz = new int[3][];
for(int i = 0; i < matriz.Length; i++)
{
    matriz[i] = new int[4];
}

