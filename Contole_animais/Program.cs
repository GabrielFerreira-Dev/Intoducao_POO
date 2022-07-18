using System;
using Contole_animais.Entities;

namespace Contole_animais
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            System.Console.WriteLine("CADASTRO DE ANIMAIS DE ESTIMAÇÃO");
            System.Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                System.Console.WriteLine($"Cadastro do {i} animal: ".ToUpper());
                System.Console.WriteLine("Qual seu tipo(cachorro/peixe/gato)?");
                System.Console.WriteLine("OBS: Caso seja diferente do informado, será cadastrado um PEIXE!"); 
                string tipo = (Console.ReadLine());
                System.Console.Write("Qual seu nome? ");
                string nome = Console.ReadLine();
                if ((tipo != "cachorro")&&(tipo != "gato")&&(tipo != "peixe"))
                {
                    tipo = "peixe";
                }
                list.Add(new Animal(tipo, nome));
                System.Console.WriteLine();
            }

            foreach (Animal animais in list)
            {
                System.Console.WriteLine(animais.ToString());
            }
            Console.ReadKey();
        }
    }
}