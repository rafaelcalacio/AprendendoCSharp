using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Calácio na área!!!");
        Console.WriteLine("7-Condicionais");

        int idade = 6;

        int pessoas = 5;

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade!!!");
        }

        else
        {
            if (pessoas >=2)
            {
                Console.WriteLine("Pivete acompanhado, pode passar!!!");
            }

            else
            {
                Console.WriteLine("Pivete, desacompanhado!!!");
            } 
                
        }

        Console.ReadLine();
    }
}