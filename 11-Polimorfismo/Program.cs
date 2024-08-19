﻿using System;

namespace _11_Polimorfismo 
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar estagiario
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("=========");

            //instanciar gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(2000);
            Console.WriteLine("=========");

            //instanciar atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
            Console.WriteLine("=========");

        }
    }
}