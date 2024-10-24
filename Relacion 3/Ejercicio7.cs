
using System;

 internal class Programa
{
    static void Main()
    {
        int[] array = { 23, 1, 45, 12, 3 };

        int posicionMenor = PosicionMenor(array);
        Console.WriteLine($"La posición del número menor es: {posicionMenor}");
    }

    static int PosicionMenor(int[] array)
    {
        int menor = array[0];
        int posicion = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menor)
            {
                menor = array[i];
                posicion = i;
            }
        }
        return posicion;
    }

}



