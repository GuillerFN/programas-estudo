using System;

namespace letras
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, resp;
            char letra;
            int conta = 0;
            do
            {
                Console.WriteLine("\n---CONTA LETRAS---");

                Console.Write("\nDigite uma frase: ");
                frase = Console.ReadLine();

                Console.Write("\nAgora, informe uma letra para ser procurada: ");
                letra = Console.ReadLine()[0];

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == letra)
                    {
                        conta++;
                    }
                }

                Console.WriteLine($"\nA letra {letra} aparece {conta} vezes.");

                Console.WriteLine("\nDeseja realizar novamente?");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S");
        }
    }
}
