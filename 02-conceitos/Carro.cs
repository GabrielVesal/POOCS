using System;

class Carro
{
    // Metodo 1
    public void acelerar(string modelo)
    {
    Console.WriteLine("Acelerando um "+ modelo +"!!");
    }
    
    // Metodo 2
    public void acelerar(string modelo, string marca)
    {
    Console.WriteLine("Acelerando um "+ modelo +" "+  marca +"!!");
    }
    
    // Metodo 3
    public void acelerar(string modelo, string marca, string cor)
    {
    Console.WriteLine("Acelerando um "+ modelo +" "+  marca +" "+ cor +"!!");
    }

    // Metodo 4
    public void acelerar(string modelo, string marca, string cor, int ano)
    {
    Console.WriteLine("Acelerando um "+ modelo +" "+  marca +" "+ cor +" "+ ano + "!!");
    }
    }