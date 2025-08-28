using System;
class Program
{
    static float Resultado = 0;
    static float a = 0;
    static float b = 0;
    
 static List<string> historico = new List<string>();
    
    public static void Main(string[] args)
    {
        a = float.Parse(Console.ReadLine());
        char operação = char.Parse(Console.ReadLine());

        if(operação == '+')
        {
            b = float.Parse(Console.ReadLine());
            soma();
            Console.WriteLine(Resultado);
             Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            AdicionarHistorico($"{a} + {b} = {Resultado}");
        }
        else if(operação == '-')
        {
            b = float.Parse(Console.ReadLine());
            subtração();
            Console.WriteLine(Resultado);
             Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            AdicionarHistorico($"{a} - {b} = {Resultado}");
        }
         else if (operação == '*')
        {
            Multiplicacao();
            Console.WriteLine(Resultado);
              Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
             AdicionarHistorico($"{a} * {b} = {Resultado}");
        }
         else if(operação == '/')

        {
            Divisão();
            Console.WriteLine(resultado)
                 Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
             AdicionarHistorico($"{a} * {b} = {Resultado}");
        }
        else if(operação == '~')
        {
            raizquadrada();
            Console.WriteLine(Resultado);
             Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            AdicionarHistorico($"{a} = {Resultado}");
        }
        else
        {
            Console.WriteLine("Operação invalida.");
            return;
        }
        Console.WriteLine("\n Histórico de operações:");
        MostrarHistorico();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static void soma()
    {
        Resultado = a+b;
    }

    static void subtração()
    { 
        Resultado = a - b; 
    }
     static void Multiplicacao()
    {
        Resultado = a * b;
    }
     static void Divisao()
    {
        if (b != 0)
        {
            Resultado = a / b;
        }

    static void raizquadrada()
    {
        float raiz = (float)Math.Sqrt(a);
        Resultado = raiz;
    }
}
   static void AdicionarHistorico(string op)
    {
        if (historico.Count == 5)
        {
            historico.RemoveAt(0);
        }
        historico.Add(op);
    }

    static void MostrarHistorico()
    {
        foreach (var op in historico)
        {
            Console.WriteLine(op);
        }
    }
}





