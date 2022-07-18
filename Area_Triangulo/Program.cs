using Area_Triangulo.Entities;

namespace Area_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qual valor da base do quadrado ou retângulo? ");
            double _base = double.Parse(Console.ReadLine());
            System.Console.Write("E qual o valor da altura? ");
            double altura = double.Parse(Console.ReadLine());
            AreaRet ret = new AreaRet(_base, altura);
            double area = ret.CalculaArea();
            System.Console.WriteLine();
            System.Console.WriteLine($"Com a base valendo {_base} e altura valendo {altura}");
            System.Console.WriteLine("Valor da área: " + area.ToString("F2"));
            Console.ReadKey();
        }
    }
}