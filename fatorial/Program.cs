using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fat;
            string resp;

            Console.WriteLine("\n---FATORIAL DIGITAL---");
            do
            {
                Console.Write("\nInforme um número: ");
                num = Int32.Parse(Console.ReadLine());

                fat = num;

                for (int i = num - 1; i >= 1; i--)
                {
                    fat = fat * i;
                }

                Console.WriteLine($"\nO resultado é {fat}");

                Console.WriteLine("\nDeseja realizar novamente? (S/N)");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S");
            
        }
    }
}
