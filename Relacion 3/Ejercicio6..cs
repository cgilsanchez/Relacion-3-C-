
using System;

 internal class Programa
{
    static void Main()
    {
        int intentos = 3;
        while (intentos > 0)
        {
            Console.Write("Introduce el usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Introduce la contraseña: ");
            string contraseña = Console.ReadLine();

            if (ValidarLogin(usuario, contraseña))
            {
                Console.WriteLine("Login exitoso.");
                break;
            }
            else
            {
                intentos--;
                Console.WriteLine($"Login fallido. Te quedan {intentos} intentos.");
            }

            if (intentos == 0)
            {
                Console.WriteLine("Has agotado tus intentos.");
            }
        }
    }

    static bool ValidarLogin(string usuario, string contraseña)
    {
        return usuario == "usuario2DAM" && contraseña == "pass2DAM";
    }

}



