using System;
using Contribuintes.Entities;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>();
            System.Console.Write("Quantos contribuintes deseja cadastrar?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"CONTRIBUINTE #{i}: ");
                System.Console.Write("Pessoa física ou jurídica(f/j)? ");
                char resp = char.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                if ((resp == 'f')||(resp == 'F'))
                {
                    System.Console.Write("Qual foi seu gasto de saúde?: ");
                    double gastoSaude = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else if ((resp == 'j')||(resp == 'J'))
                {
                    System.Console.Write("Quantos funcionários a empresa possuí?: ");
                    int quantiaDeFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, rendaAnual, quantiaDeFuncionarios));
                }
                else
                {
                    System.Console.WriteLine("Valor inválido!");
                }
            }

            foreach (Contribuintes pessoas in list)
            {
                System.Console.WriteLine(pessoas.ToString());
            }   
            Console.ReadKey();
        }
    }
}