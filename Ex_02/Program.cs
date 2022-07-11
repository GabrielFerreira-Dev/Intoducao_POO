using System;
using System.Globalization;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            System.Console.Write("Nome:  ");
            func1.Nome = Console.ReadLine();
            System.Console.Write("Salário Bruto: ");
            func1.SalarioBruto = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Imposto: " );
            func1.Imposto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Funcionário " + func1);
            System.Console.WriteLine();
            System.Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func1.AumentarSalario(porcent);
            
            System.Console.WriteLine("Funcionário " + func1);
            Console.ReadKey();  

        }
    }
}