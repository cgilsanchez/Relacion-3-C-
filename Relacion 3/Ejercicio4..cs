
using System;

 internal class Programa
{

    static void Main()
    {
        Console.Write("Introduce un número: ");
        int numero = int.Parse(Console.ReadLine());

        bool esPrimo = EsPrimo(numero);
        if (esPrimo)
            Console.WriteLine($"{numero} es un número primo.");
        else
            Console.WriteLine($"{numero} no es un número primo.");
    }

    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}



