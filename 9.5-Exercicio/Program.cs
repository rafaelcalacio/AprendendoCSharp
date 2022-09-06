using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3901.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Deduzir na declaração o valor de R$ 142");
        }
        else if (salario >= 2800.1 && salario <= 3751.0)
        {
            Console.WriteLine("Deduzir na declaração o valor de R$ 350");
        }
        else if (salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("Deduzir na declaração o valor de R$ 636");
        }
        else
        {
            Console.WriteLine("Ou você ganha muito pouco e não precisa declarar, ou você ganha muito e precisará de um contador!!!");
        }

    }
}

/*
De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.*/