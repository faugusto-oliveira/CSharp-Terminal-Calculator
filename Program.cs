using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }
        static void Soma()
        {
            Console.Clear();
            Console.Write("Por favor digite os valores: ");
            double numero1 = float.Parse(Console.ReadLine());
            double numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da soma de {0} com {1} é {2}", numero1, numero2, numero1+numero2);
        }
        static void Subtracao()
        {

        }
        static void Multiplicacao()
        {

        }
        static void Divisao()
        {

        }
    }
    
}
