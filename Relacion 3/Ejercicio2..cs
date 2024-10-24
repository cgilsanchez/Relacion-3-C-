
using System;

 internal class Programa
{
    static void Main()
    {
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();

        int espacios = ContarEspacios(texto);
        Console.WriteLine($"El número de espacios en blanco es: {espacios}");
    }

    static int ContarEspacios(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if (c == ' ') contador++;
        }
        return contador;
    }
}

