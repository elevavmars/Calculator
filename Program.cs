﻿namespace Calculator
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
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            
            Console.WriteLine("--------------");
            
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("Resultado da soma é: " + resultado);
            Console.WriteLine($"Resultado da soma é: {resultado}");
            // Console.WriteLine($"Resultado da soma é: {v1 + v2}");
            // Console.WriteLine($"Resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            float resultado = v1 - v2;
            Console.WriteLine($"Resultado da subtração: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            float resultado = v1 / v2;
            Console.WriteLine($"Resultado da Divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            float resultado = v1 * v2;
            Console.WriteLine($"Resultado da Multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
