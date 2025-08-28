
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
        b = float.Parse(Console.ReadLine());
        
        if(operação == '+')
        {
            soma();
            Console.WriteLine(Resultado);
        }
        else if(operação == '-')
        {
            subtração();
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
 resultado = a + b;
  }
    static void subtração()
  { 

  }
}


