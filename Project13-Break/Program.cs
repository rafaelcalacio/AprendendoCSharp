using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Comando Break");
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Calácio na área!!!");

        for (int contadorLinhas = 0; contadorLinhas < 15; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 15; contadorColunas++)
            {
                Console.Write("%");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }
       
       
    }
}