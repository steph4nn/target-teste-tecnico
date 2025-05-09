using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target_teste_tecnico
{
    public class Questao1
    {
        public static void Execute()
        {
            int index = 13;
            int sum = 0, k = 0;

            while (k < index)
            {
                k = k+ 1;
                sum = sum+ k;
            }

            Console.WriteLine($"o valor final da variável sum é: {sum}");
        }

    }
}
