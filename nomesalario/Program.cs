using System;

namespace nomesalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---CADASTRO NOME-SALÁRIO---");
            
            #region variáveis
            const int MAX = 50;
            string[] nomes = new string[MAX];
            double[] salarios = new double[MAX];
            int qtde = 0;
            char resp;
            #endregion

            #region cadastro
            for (int n = 0; n < MAX; n++)
            {
                qtde++;

                do
                {
                    Console.WriteLine("Digite o nome: ");
                    nomes[n] = Console.ReadLine().Trim();
                }
                while (nomes[n].Length == 0);

                do
                {
                    Console.Write("Digite salário: ");
                    salarios[n] = double.Parse(Console.ReadLine());
                }
                while (salarios[n] < 0 || salarios[n] > 15000);


                if (n < MAX - 1)
                {
                    Console.Write("Deseja continuar? <s/n>: ");
                    resp = Console.ReadLine().ToUpper()[0];
                    if (resp == 'N')
                        break;
                }
            }

            #endregion

            #region menu

            #endregion

            do
            {
                Console.WriteLine("\n\n1 -) Listar todos os cadastrados no formato: nome - salário.");
                Console.WriteLine("2 -) Exibir todas as ocorrências de quem tem o menor salário.        ");
                Console.WriteLine("3 -) Exibir só o sobrenome de todos os cadastrados. Se não houver sobrenome, exiba o primeiro nome.");
                Console.WriteLine("4 -) Exibir a média salarial");
                Console.WriteLine("6 -) Sair");
                resp = Console.ReadLine().ToUpper()[0];

                if (resp == '1')
                {
                    Console.WriteLine("\n\nListagem: ");
                    for (int n = 0; n < qtde; n++)
                        Console.WriteLine($"{nomes[n]} - {salarios[n]}");
                }
                else if (resp == '2')
                {
                    double menor = salarios[0];
                    for (int n = 0; n < qtde; n++)
                        if (salarios[n] < menor)
                            menor = salarios[n];

                    Console.WriteLine("\n\nListagem de quem ganha o menor salário, que é {0:F2}: ", menor);
                    for (int n = 0; n < qtde; n++)
                    {
                        if (salarios[n] == menor)
                            Console.WriteLine($"Posição: {n} - {nomes[n]} - {salarios[n]}");
                    }
                }
                else if (resp == '3')
                {
                    Console.WriteLine("\n\nListagem apenas dos primeiros nomes: ");
                    for (int n = 0; n < qtde; n++)
                    {
                        int posicaoEspaco = nomes[n].IndexOf(' ');
                        if (posicaoEspaco == -1)
                            Console.WriteLine($"{nomes[n]}");
                        else
                            Console.WriteLine($"{nomes[n].Substring(posicaoEspaco+1)}");
                    }
                }
                else if (resp == '4')
                {
                    double soma = 0;
                    for (int n = 0; n < qtde; n++)
                        soma += salarios[n];
                    Console.WriteLine("\n\nMédia salárial: {0:F2}", soma / qtde);
                }

            } while (resp != '6');
        }
    }
}
