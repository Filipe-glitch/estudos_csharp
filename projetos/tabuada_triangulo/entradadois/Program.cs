using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace entradadois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0; // aqui é a definição da variável n que será um valor inteiro.
            string entrada = ""; //aqui é a definição da variável entrada com o tipo de dado string.
           
            Console.WriteLine("tabuada de um número");
            Console.WriteLine("diga um número");
            entrada = Console.ReadLine(); //aqui a pessoa irá informar o número em formato de string.
            n = Convert.ToInt32(entrada); // aqui esse número em formato de string será convertido em um tipo inteiro de 32 bits.
            Console.WriteLine("Tabuada do " + n);
            Console.WriteLine(n + " x 1 = " + (n * 1));
            Console.WriteLine(n + " x 2 = " + (n * 2));
            Console.WriteLine(n + " x 3 = " + (n * 3));
            Console.WriteLine(n + " x 4 = " + (n * 4));
            Console.WriteLine(n + " x 5 = " + (n * 5));
            Console.WriteLine(n + " x 6 = " + (n * 6));
            Console.WriteLine(n + " x 7 = " + (n * 7));
            Console.WriteLine(n + " x 8 = " + (n * 8));
            Console.WriteLine(n + " x 9 = " + (n * 9));
            Console.WriteLine(n + " x 10 = " + (n * 10));
            Console.WriteLine(n + " x 11 = " + (n * 11));
            Console.WriteLine(n + " x 12 = " + (n * 12));
            
            // calcular altura do triângulo
           
            double b = 0; // b = base 
            double h = 0; // h = altura
            double a = 0; // a = área do triângulo
            
            string entrada1 = "";

            Console.WriteLine("área do triângulo");
            Console.WriteLine("informe a base do triângulo");
            entrada1 = Console.ReadLine();     //aqui a pessoa irá informar o valor em string
            b = Convert.ToDouble(entrada1);   // aqui novamente o processo de conversão de string mas dessa vez no tipo de dado double.
            Console.WriteLine("Informe a altura do triângulo");
            entrada1 = Console.ReadLine();
            h = Convert.ToDouble(entrada1);

            a = (b * h) / 2;

            Console.WriteLine("área do triângulo");
            Console.WriteLine("base do triângulo = " + b);
            Console.WriteLine("altura do triângulo = " + h);
            Console.WriteLine("área do triângulo = " + a);
            Console.ReadKey();

        }
    }
}
