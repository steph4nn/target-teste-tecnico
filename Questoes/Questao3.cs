using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using target_teste_tecnico.Models;

namespace target_teste_tecnico
{
    public class Questao3
    {
        public static void Execute()
        {
            string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recursos", "dados.json");
            string json = File.ReadAllText(filename);
            var list = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            decimal minValue = decimal.MaxValue;
            decimal maxValue = decimal.MinValue;
            decimal sum = 0;
            int daysWithRevenue = 0;

            foreach (var item in list)
            {
                if (item.valor > 0)
                {
                    if (item.valor < minValue)
                        minValue = item.valor;

                    if (item.valor > maxValue)
                        maxValue = item.valor;

                    sum += item.valor;
                    daysWithRevenue++;
                }
            }

            decimal avgMonth = sum / daysWithRevenue;

            int daysAboveAvg = 0;
            foreach (var item in list)
            {
                if (item.valor > avgMonth)
                    daysAboveAvg++;
            }

            Console.WriteLine($"menor valor de faturamento ocorrido em um dia do mês: {minValue:C}");
            Console.WriteLine($"maior valor de faturamento ocorrido em um dia do mês: {maxValue:C}");
            Console.WriteLine($"número de dias no mês em que o valor de faturamento diário foi superior a média mensal: {daysAboveAvg}");

        }

    }
}
