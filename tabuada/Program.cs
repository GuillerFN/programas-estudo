using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            string resp;

            Console.WriteLine("\n---TABUADA DIGITAL---");

            do
            {
                Console.Write("\nInforme um número: ");
                num = Int32.Parse(Console.ReadLine());

                for (int i = 0; i <= 10; i++)
                {
                    result = num * i;
                    Console.WriteLine($"{num} X {i} = {result}");
                }
                
                Console.WriteLine("\nDeseja realizar novamente? (S/N)");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S");
            
        }
    }
}
