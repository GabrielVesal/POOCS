using System;

namespace _01_conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Carro obj = new Carro();
            obj.modelo = "Corolla";
            obj.marca = "Toyota";
            obj.cor = "Preto";
            obj.ano = 2024;
            obj.acelerar();

        }
        
    }
    
}

