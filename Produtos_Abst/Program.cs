using System;
using Produtos_Abst.Entities;

namespace Produtos_Abst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();
            System.Console.Write("Quantos produtos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"produto #{i} data: ".ToUpper());
                System.Console.Write("Produto comum, usado ou importado(c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());
                if ((resp == 'c')||(resp == 'C'))
                {
                    list.Add(new Produto(nome, preco));
                }
                else if ((resp == 'i')||((resp == 'I')))
                {
                    System.Console.Write("Preço adicional: ");
                    double precoAdicional = double.Parse(Console.ReadLine());
                    list.Add(new ProdutoImportado(nome, preco, precoAdicional));
                }
                else if ((resp == 'u')||(resp == 'U'))
                {
                    System.Console.WriteLine("Data de manufatura: ");
                    string manufatura = Console.ReadLine();
                    list.Add(new ProdutoUsado(nome, preco, manufatura));
                }
                System.Console.WriteLine(); 
            }
            System.Console.WriteLine();

            foreach (Produto prod in list)
            {
                System.Console.WriteLine(prod.PriceTag());
            }
            Console.ReadKey();  
        }
    }
}