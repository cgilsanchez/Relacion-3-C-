
using System;

class Cliente
{
    private string nombre;        
    private double cantidadTotal;
    public Cliente(string nombre)
    {
        this.nombre = nombre;
        this.cantidadTotal = 0; 
    }

    
    public void Ingresar(double cantidad)
    {
        if (cantidad > 0)
        {
            cantidadTotal += cantidad;
            Console.WriteLine($"{nombre} ha ingresado {cantidad} euros.");
        }
        else
        {
            Console.WriteLine("La cantidad a ingresar debe ser mayor que cero.");
        }
    }

    
    public void Sacar(double cantidad)
    {
        if (cantidad <= cantidadTotal)
        {
            cantidadTotal -= cantidad;
            Console.WriteLine($"{nombre} ha retirado {cantidad} euros.");
        }
        else
        {
            Console.WriteLine($"{nombre} no tiene suficiente saldo para retirar {cantidad} euros.");
        }
    }


    public double GetCantidadTotal()
    {
        return cantidadTotal;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Cliente: {nombre}, Saldo actual: {cantidadTotal} euros.");
    }
}

class Banco
{
    private Cliente[] clientes; 

    
    public Banco()
    {
        clientes = new Cliente[3];
        clientes[0] = new Cliente("Juan");
        clientes[1] = new Cliente("María");
        clientes[2] = new Cliente("Carlos");
    }

   
    public void Operar()
    {
        clientes[0].Ingresar(1000);  
        clientes[1].Ingresar(2000); 
        clientes[2].Ingresar(1500); 

        clientes[0].Sacar(300);      
        clientes[1].Sacar(500);     
    }

    public void ObtenerEstado()
    {
        double totalBanco = 0;

        foreach (Cliente cliente in clientes)
        {
            cliente.MostrarInformacion();
            totalBanco += cliente.GetCantidadTotal();
        }

        Console.WriteLine($"El total ingresado en el banco es: {totalBanco} euros.");
    }

    static void Main()
    {
        Banco banco = new Banco();  
        banco.Operar();             
        banco.ObtenerEstado();      
    }
}


