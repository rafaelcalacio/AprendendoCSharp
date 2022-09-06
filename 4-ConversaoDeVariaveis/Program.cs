using System;
class Programa
{
    static void Main(string[] args)
    {
       /*comentários*/

        //conversão de tipos

        double numero1 = 33.67;

        double numero2 = 3;

        int total = (int)numero1 / (int)numero2;

        Console.WriteLine(total);

        float altura = 1.76f;

        float peso = 69.9f;

        float imc = peso / (altura * altura);
        
        Console.WriteLine("Seu IMC é " + imc);

        Console.ReadLine();

    }
}