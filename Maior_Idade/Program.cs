using System;
using Maior_Idade.Entities;

namespace Maior_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorIdade = 0;
            
            List<Pessoa> list = new List<Pessoa>();
            Pessoa mIdade = new Pessoa();

            System.Console.Write("Quantas pessoas deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            System.Console.WriteLine("Cadstro de pessoa".ToUpper());
            for (int i = 1; i <= n; i++)
            {                
                System.Console.WriteLine();
                System.Console.WriteLine($"PESSOA #{i}");
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                list.Add(new Pessoa(nome, idade));
                if (idade >= maiorIdade)
                {
                    mIdade = new Pessoa(nome, idade);
                }                
            }
            
            foreach (Pessoa pessoa in list)
            {                
                System.Console.WriteLine(pessoa.exibirDados());
            }
            
            System.Console.WriteLine("Maior idade: " + mIdade.exibirDados());

            Console.ReadKey();   
        }
    }
}