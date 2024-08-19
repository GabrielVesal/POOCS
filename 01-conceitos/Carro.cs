using System;

// Classe:
class Carro
{
    // Atributos:
    public string modelo;
    public string marca;
    public string cor;
    public int ano;

    
    // Metodos:
    public void acelerar()
    {
        Console.WriteLine("Acelerando um "+ modelo +" "+  marca +" "+ cor +" "+ ano);
    }
}