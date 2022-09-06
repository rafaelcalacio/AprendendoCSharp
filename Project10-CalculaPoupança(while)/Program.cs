using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Calácio na área!!!");
        

        int mes = 1;
        double investimento = 3000.00;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.007;
            Console.WriteLine("No mês " + mes + " você terá o patrimônio de " + investimento);
            // + 1 = "++" autoincremento, ou pode ser "+="
            mes ++;
                     
        }
        Console.ReadLine();
    }
}