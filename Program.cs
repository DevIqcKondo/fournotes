using System;

namespace fournotes
{
    class Program
    {
        static void Main(string[] args)
        {
            double m1=0;
            double m2=0;
            double m3=0;
            double m4=0;
            double r=0;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Descubra sua média final!");
            Console.WriteLine("-------------------------");

            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("Digite suas notas abaixo: ");
            Console.WriteLine("Digite somente notas entre 0 e 10.");
            Console.ResetColor();

            Console.WriteLine("Nota 1: ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            m1=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine("Nota 2: ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            m2=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine("Nota 3: ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            m3=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine("Nota 4: ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            m4=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            
            r=(m1+m2+m3+m4)/4;

            if(r>6){
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("Você ficou com média "+r+". Resultado: Aprovado");
                Console.ResetColor();

            }else if(r<5){
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("Você ficou com média "+r+". Resultado: Reprovado");
                Console.ResetColor();

            }else if(r>=5&&r<=6){
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("Você ficou com média "+r+". Resultado: Em recuperação");
                Console.ResetColor();
          }
            Console.Beep();
                

        }
    }
}
