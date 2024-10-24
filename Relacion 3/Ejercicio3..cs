
using System;

 internal class Programa
{
  
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int numero = int.Parse(Console.ReadLine());

        long factorial = CalcularFactorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    static long CalcularFactorial(int n)
    {
        if (n <= 1) return 1;
        return n * CalcularFactorial(n - 1);
    }
}



