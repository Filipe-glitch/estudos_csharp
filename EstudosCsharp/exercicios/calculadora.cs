using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class calculadora
    {
        public static void calculaorateste()
        {
        inicio3:
            Console.Clear();
            Console.WriteLine("Bem vindo ao sistema de calculadora ");
            Console.Write("Escolha um número ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Escolha o segundo número ");
            double num2 = double.Parse(Console.ReadLine());
        inicio:
            Console.WriteLine(" ------------------------------");
            Console.Write("Agora , escolha a operação (+ - x / ) ");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                default:
                    Console.WriteLine("insira uma operação válida");
                    goto inicio;
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case 'X':
                case 'x':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("numa divisão não é possível dividir por 0 ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(num1 / num2);
                        break;
                    }
            }
            Console.WriteLine("Deseja continuar usando a calculadora ? (s / n) ");
            string opcao = Console.ReadLine();
            if (opcao == "s" || opcao == "S")
                goto inicio3;

            Console.ReadKey();

        }
    }
}
