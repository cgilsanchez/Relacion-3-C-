
using System;

 internal class Programa
{
    static void Main()
    {
        Console.Write("Introduce la base: ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.Write("Introduce el exponente: ");
        int exponente = int.Parse(Console.ReadLine());

        Console.WriteLine($"Resultado (Iterativo): {PotenciaIterativa(baseNum, exponente)}");
        Console.WriteLine($"Resultado (Recursivo): {PotenciaRecursiva(exponente, baseNum)}");
    }

    static long PotenciaIterativa(int baseNum, int exp)
    {
        long resultado = 1;
        for (int i = 0; i < exp; i++)
        {
            resultado *= baseNum;
        }
        return resultado;
    }

    static long PotenciaRecursiva(int baseNum, int exp)
    {
        if (exp == 0) return 1;
        return baseNum * PotenciaRecursiva(baseNum, exp - 1);
    }

}



