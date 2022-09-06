using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Calácio na área!!!");
        Console.WriteLine("Desafio 1 - Múltiplos de 4");


        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 4 == 0)
            {
                Console.WriteLine(numero);
            }
              
           
        }
       // Console.ReadLine();
    }
}