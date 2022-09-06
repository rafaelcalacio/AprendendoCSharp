using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento a longo prazo!");
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Calácio na área!!!");

        double investimento = 3000.00;
        double fatorRendimento = 1.005;

        for (int ano = 1; ano < 6; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento = investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }
        Console.WriteLine("Depois de 5 anos você terá o patrimônio de R$" + investimento);
       
    }
}