using System.Text;
using System;

namespace target_teste_tecnico
{
    public class Questao5
    {
        public static void Execute()
        {
            string word = "Paralelepipedo";
            StringBuilder invertedWord = new StringBuilder();          
                                                              
            for (var i = word.Length - 1; i >= 0; i--)
            {
                invertedWord.Append(word[i]);
            }
            Console.WriteLine("String original: "+word);
            Console.WriteLine("String invertida: "+invertedWord.ToString());


        }

    }
}
