using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio

{
    class Voais
    {
        static void Main(string[] args)
        {
            char[] stringRecebida;
            char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int quantidadeVogais = 0;

            Console.WriteLine("Digite a palavra ou frase que será contada: ");
            stringRecebida = Console.ReadLine().ToLower().ToCharArray();
            Console.WriteLine();

            for (int i = 0; i < stringRecebida.Length; i++)
            {
                for (int j = 0; j < vogais.Length; j++)
                {
                    if (stringRecebida[i] == vogais[j])
                    {
                        quantidadeVogais++;
                    }
                }
            }
            Console.WriteLine("A quantidade de vogais é: " + quantidadeVogais);

            Console.ReadKey();
        }

    }

}
