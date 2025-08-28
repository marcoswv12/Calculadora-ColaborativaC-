using System;
using System.Collections.Generic;  // Para usar List

class Program
{
    static float Resultado = 0;
    static float a = 0;
    static float b = 0;

    static List<string> historico = new List<string>();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número (ou 'x' para sair):");
            string entradaA = Console.ReadLine();
            if (entradaA.ToLower() == "x")
                break;
            
            if (!float.TryParse(entradaA, out a))
            {
                Console.WriteLine("Número inválido!");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine("Digite a operação (+, -, *, /, ~) ou 'x' para sair:");
            string entradaOp = Console.ReadLine();
            if (entradaOp.ToLower() == "x")
                break;

            if (entradaOp.Length != 1)
            {
                Console.WriteLine("Operação inválida!");
                Console.ReadKey();
                continue;
            }

            char operação = entradaOp[0];

            if (operação == '+' || operação == '-' || operação == '*' || operação == '/')
            {
                Console.WriteLine("Digite o segundo número:");
                string entradaB = Console.ReadLine();

                if (!float.TryParse(entradaB, out b))
                {
                    Console.WriteLine("Número inválido!");
                    Console.ReadKey();
                    continue;
                }
            }

            switch (operação)
            {
                case '+':
                    soma();
                    Console.WriteLine($"Resultado: {Resultado}");
                    AdicionarHistorico($"{a} + {b} = {Resultado}");
                    break;
                case '-':
                    subtração();
                    Console.WriteLine($"Resultado: {Resultado}");
                    AdicionarHistorico($"{a} - {b} = {Resultado}");
                    break;
                case '*':
                    Multiplicacao();
                    Console.WriteLine($"Resultado: {Resultado}");
                    AdicionarHistorico($"{a} * {b} = {Resultado}");
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida!");
                    }
                    else
                    {
                        Divisao();
                        Console.WriteLine($"Resultado: {Resultado}");
                        AdicionarHistorico($"{a} / {b} = {Resultado}");
                    }
                    break;
                case '~':
                    raizquadrada();
                    Console.WriteLine($"Resultado: {Resultado}");
                    AdicionarHistorico($"√{a} = {Resultado}");
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("\nHistórico das últimas operações:");
            MostrarHistorico();

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("Programa encerrado.");
    }

    static void soma() => Resultado = a + b;

    static void subtração() => Resultado = a - b;

    static void Multiplicacao() => Resultado = a * b;

    static void Divisao() => Resultado = a / b;

    static void raizquadrada() => Resultado = (float)Math.Sqrt(a);

    static void AdicionarHistorico(string op)
    {
        if (historico.Count == 5)
            historico.RemoveAt(0);

        historico.Add(op);
    }

    static void MostrarHistorico()
    {
        foreach (var op in historico)
            Console.WriteLine(op);
    }
}
