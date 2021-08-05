using System;

namespace palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool palindromo = true;
            int tamanho, cont = 0;
            string frase, resp;

            Console.WriteLine("\n---PALÍNDROMO DIGITAL---");
            do
            {
                Console.Write("\nDigite uma Frase: ");
                frase = Console.ReadLine();

                tamanho = frase.Length;
                cont = 0;
                do
                {
                    if (frase[cont] != frase[tamanho - 1 - cont])
                    {
                        palindromo = false;
                        break;
                    }
                    cont++;
                } while (cont <= tamanho / 2);

                if (palindromo == true)
                {
                    Console.WriteLine("\nÉ Palíndromo");
                }   
                else
                {
                    Console.WriteLine("\nNão é Palíndromo");
                }

                Console.WriteLine("\nDeseja realizar novamente? (S/N)");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S");
            
        }
    }
}
