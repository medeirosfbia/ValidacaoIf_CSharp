using System;

namespace VaidacaoIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu número de telefone colocando um espaço entre DDD e os outros dígitos:");
            string[] telefone = Console.ReadLine().Split(' ');
            int DDD = int.Parse(telefone[0]);
            string N = telefone[1];
            string nonoDigito = N[0].ToString();

            if (DDD == 11)
            {
                Console.WriteLine("DDD de São Paulo");

                if (nonoDigito == "9")
                {
                    if (N.Length == 9)
                    {
                        Console.WriteLine("Número de telefone válido");
                    }
                    else
                    {
                        Console.WriteLine("Número de telefone não existente");
                    }
                }
                else
                {
                    Console.WriteLine("Número de telefone não existente");
                }
            }
            else
            {
                Console.WriteLine("DDD não cadastrado no sistema");
            }
        }
    }
}