
using System;

 internal class Programa
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int numero = int.Parse(Console.ReadLine());

        int sumaDigitos = SumarDigitos(numero);

        Console.WriteLine($"La suma de los dígitos es: {sumaDigitos}");
    }
    static int SumarDigitos(int n)
    {
        int suma = 0;

        while (n != 0)
        {
            suma += n % 10;  
            n /= 10;         
        }

        return suma;
    }

}



