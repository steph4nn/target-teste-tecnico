using System;

namespace target_teste_tecnico
{
    public class Questao2
    {
        public static void Execute()
        {
            Console.Write("digite um número: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int a = 0, b = 1, temp = 0;

                while (b < n)
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                }

                if (n == 0 || n == b)
                {
                    Console.WriteLine($"o número {n} pertence a sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"o número {n} não pertence a sequência de Fibonacci.");
                }
            }
            else
            {
                Console.WriteLine("é necessário inserir um valor númerico.");
            }
        }

    }
}
