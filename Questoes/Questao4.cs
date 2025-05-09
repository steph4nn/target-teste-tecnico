using System;
using System.Collections.Generic;

namespace target_teste_tecnico
{
    public class Questao4
    {
        public static void Execute()
        {
            var revenuePerState = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };


            double totalRevenue = 0;
            foreach (var valor in revenuePerState.Values)
            {
                totalRevenue += valor;
            }

            Console.WriteLine("percentual de cada estado:");
            foreach (var state in revenuePerState)
            {
                double percentual = (state.Value / totalRevenue) * 100;
                Console.WriteLine($"{state.Key}: {percentual:F2}%");
            }
        }

    }
}
