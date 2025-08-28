using System;
class Program
{
    static float Resultado = 0;
    static float a = 0;
    static float b = 0;

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
        }
        else if(operação == '-')
        {
            b = float.Parse(Console.ReadLine());
            subtração();
            Console.WriteLine(Resultado);
             Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
        }
         else if (operação == '*')
        {
            Multiplicacao();
            Console.WriteLine(Resultado);
              Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
        }
        else if(operação == '~')
        {
            raizquadrada();
            Console.WriteLine(Resultado);
             Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Operação invalida.");
            return;
        }
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

    static void raizquadrada()
    {
        float raiz = (float)Math.Sqrt(a);
        Resultado = raiz;
    }
}




