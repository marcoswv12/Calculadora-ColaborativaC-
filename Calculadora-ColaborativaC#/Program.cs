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
        }
        else if(operação == '-')
        {
            b = float.Parse(Console.ReadLine());
            subtração();
            Console.WriteLine(Resultado);
        }
        else if(operação == '~')
        {
            raizquadrada();
            Console.WriteLine(Resultado);
        }
        else
        {
            Console.WriteLine("Operação invalida.");
            return;
        }
    }

    static void soma()
    {
        Resultado = a + b;
    }

    static void subtração()
    { 
        Resultado = a - b;
    }

    static void raizquadrada()
    {
        float raiz = (float)Math.Sqrt(a);
        Resultado = raiz;
    }
}
