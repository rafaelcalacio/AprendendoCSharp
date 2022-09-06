using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("9-Escopo");
        Console.WriteLine("Olá, Mundo!");
        Console.WriteLine("Calácio na área!!!");
        

        int idade = 26;

        int pessoas = 2;

        bool acompanhado = pessoas > 1;

        //Escopo é o que fica dentro do bloco....exemplo uma variável que foi declarada apena no bloco. Ela só pode ser usada nesse escopo, não é global.
        if (idade >= 18 || acompanhado)
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