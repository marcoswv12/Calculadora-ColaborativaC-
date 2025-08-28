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
    using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma expressão com parênteses (ex: (2+3)*4):");
        string parentesis = Console.ReadLine();

        // 1: pegar o que está dentro dos parênteses
        int pos1 = -1;
        int pos2 = -1;

        int i = 0;
        while (i < parentesis.Length)
        {
            if (parentesis[i] == '(')
            {
                pos1 = i;
            }
            if (parentesis[i] == ')')
            {
                pos2 = i;
                break; // achou o final
            }
            i++;
        }

        double valorParenteses = 0;

        if (pos1 != -1 && pos2 != -1)
        {
            // Exemplo: (2+3)
            char numero1 = parentesis[pos1 + 1]; // pega o 2
            char operacao = parentesis[pos1 + 2]; // pega o +
            char numero2 = parentesis[pos1 + 3]; // pega o 3

            int n1 = numero1 - '0'; // transforma char em número
            int n2 = numero2 - '0';

            if (operacao == '+') valorParenteses = n1 + n2;
            if (operacao == '-') valorParenteses = n1 - n2;
            if (operacao == '*') valorParenteses = n1 * n2;
            if (operacao == '/') valorParenteses = n1 / (double)n2;
        }

        // 2: usar o resultado do parêntese no resto da conta
        // ex: (x+y)*z
        char operacaoFinal = parentesis[pos2 + 1]; // pega o *
        char numeroFinal = parentesis[pos2 + 2];  // pega o 4

        int nFinal = numeroFinal - '0';

        double resultado = 0;
        if (operacaoFinal == '+') resultado = valorParenteses + nFinal;
        if (operacaoFinal == '-') resultado = valorParenteses - nFinal;
        if (operacaoFinal == '*') resultado = valorParenteses * nFinal;
        if (operacaoFinal == '/') resultado = valorParenteses / nFinal;

        Console.WriteLine("Resultado: " + resultado);
    }
}
}





