using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Calácio na área!!!");
        Console.WriteLine("7-Condicionais");

        int idade = 26;

        int pessoas = 2;

        if (idade >= 18 && pessoas >= 2)
        {
            Console.WriteLine("Você pode ir!!!");
        }

        else
        {                       
            Console.WriteLine("Você não pode ir!!!");            
        }

        Console.ReadLine();
    }
}