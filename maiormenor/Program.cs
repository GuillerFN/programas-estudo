using System;

namespace maiormenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---MAIOR MENOR---");
            Console.WriteLine("");

            string resp;
            int[] numeros = new int[5];
            int maior = 0, menor = 0, i;

            do
            {
                for (i = 0; i < 5; i++)
                {
                    Console.Write("Digite um numero: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());

                    if (i == 0)
                    {
                        maior = numeros[i];
                        menor = numeros[i];
                        continue;
                    }

                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }

                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                }

                Console.WriteLine("");

                for (i = 0; i < 4; i++)
                {
                    Console.Write($"{numeros[i]} - ");
                }
                Console.Write($"{numeros[i]}");

                Console.WriteLine($"\nO maior número digitado foi {maior}");
                Console.WriteLine($"O menor número digitado foi {menor}");

                Console.WriteLine("\nDeseja realizar novamente? (S/N)");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S");
        }
    }
}
