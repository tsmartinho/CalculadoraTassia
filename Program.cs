using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===========CALCULADORA DA TÁSSIA===========\n");
            Console.Write("Insira o primeiro algarismo: "); https://github.com/tsmartinho?tab=repositories
            int primeiroalgarismo = int.Parse (Console.ReadLine());            
            Console.Write("\nInsira o segundo algarismo: ");
            int segundoalgarismo = int.Parse (Console.ReadLine());           
            Console.WriteLine("\nInsira 1 para adição\n2 para subtração\n3 para divisão\n4 para multiplicação");
            int operação = int.Parse (Console.ReadLine());

            if (operação == 1)
            {
                Console.Clear();
                int resultado = primeiroalgarismo + segundoalgarismo;
                Console.Write("O resultado da operação " + primeiroalgarismo + " + " + segundoalgarismo + " é: " + resultado);
                Console.ReadKey();
            }
            if (operação == 2)
            {
                Console.Clear();
                int resultado = primeiroalgarismo - segundoalgarismo;
                Console.WriteLine("O resultado da operação " + primeiroalgarismo + " - " + segundoalgarismo + " é: " + resultado);
                Console.ReadKey();
            }
            if (operação == 3)
            {
                Console.Clear();
                int resultado = primeiroalgarismo / segundoalgarismo;
                Console.WriteLine("O resultado da operação " + primeiroalgarismo + " / " + segundoalgarismo + " é: " + resultado);
                Console.ReadKey();
            } 
            else if (operação == 4)
            {
                Console.Clear();
                int resultado = primeiroalgarismo * segundoalgarismo;
                Console.WriteLine("O resultado da operação " + primeiroalgarismo + " * " + segundoalgarismo + " é: " + resultado);
                Console.ReadKey();
            }

        }
    }
}
