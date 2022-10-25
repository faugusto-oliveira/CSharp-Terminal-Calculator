using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seja bem vindo! O que deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            short modificador = short.Parse(Console.ReadLine());
            switch (modificador)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.Write("Por favor digite os valores: ");
            double numero1 = float.Parse(Console.ReadLine());
            double numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da soma de {0} com {1} é {2}", numero1, numero2, numero1+numero2);
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Por favor digite os valores: ");
            double numero1 = float.Parse(Console.ReadLine());
            double numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da subtração de {0} com {1} é {2}", numero1, numero2, numero1-numero2);
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Por favor digite os valores: ");
            double numero1 = float.Parse(Console.ReadLine());
            double numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da multiplicação de {numero1} com {numero2} é {numero1*numero2}");
            Menu();
        }
        static void Divisao()
        {
            try
            {
                Console.Clear();
                Console.Write("Por favor digite os valores: ");
                double numero1 = float.Parse(Console.ReadLine());
                double numero2 = float.Parse(Console.ReadLine());
                Console.WriteLine($"O resultado da divisão de {numero1} com {numero2} é {numero1/numero2}");
                Menu();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divisão por zero");
                Menu();
            }
            
        }
    }
}
