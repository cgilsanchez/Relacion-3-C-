
using System;

 internal class Programa
{
    static void Main()
    {
        Console.Write("Introduce el tamaño del array: ");
        int tamaño = int.Parse(Console.ReadLine());

        int[] numeros = new int[tamaño];
        int suma = 0;

        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }

        double media = (double)suma / tamaño;
        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"La media es: {media}");
    }
}

