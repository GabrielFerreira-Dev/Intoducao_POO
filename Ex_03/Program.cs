using System;
using System.Globalization;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            System.Console.WriteLine("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            System.Console.WriteLine("Informe a primeira nota dele: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Informe a segunda nota dele: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.WriteLine("Informe a terceira nota dele: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("ALUNO: " + aluno.Nome);
            System.Console.WriteLine("NOTA FINAL: "+ aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovacao())
            {
                System.Console.WriteLine("APROVADO!");
            }
            else
            {
                System.Console.WriteLine("REPROVADO!");
                System.Console.WriteLine("FALTAM: " + aluno.Restante());
            };          
            Console.ReadKey();
        }
    }
}