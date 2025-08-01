using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace sequefibonacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            // projeto da sequência de Fibonacci 
            // fórmula : Fn = Fn-1 + Fn-2 | n >= 3 | Fn é o termo qualquer, Fn-1 é o termo antecedente , Fn-2 é o termo antecedente a Fn-1
            // vamos dizer quantos números nós queremos que ele faça a sequência.

            int a = 0,  // VALOR ATUAL DA SEQUÊNCIA
            b = 1, //próximo valor da sequÊncia
            c = 0; // VARIÁVEL TEMPORÁRIA QUE ARMAZENA A SOMA a + b

            Console.Write(" Quantos valores você quer que a sequência de Fibonacci tenha ");
            int valores = int.Parse(Console.ReadLine());
            Console.WriteLine(" Sequência de Fibonacci com " + valores + " valores ");

            for (int i = 0; i < valores; i++) //começa com o contador i com valor = 0(primeiro valor da sequência).
                                              //i < valores . Enquanto i for menor que valores , o bloco do for será executado. i++ A cada repetição aumenta i em 1 (igual a i = i + 1).
            {
                if (i < valores - 1)
                {
                    Console.Write(a + " , "); // Se ainda não for o último número (i < valores - 1):imprime o número a seguido de vírgula e espaço:0 , 1 , 2
                   
                }
                else
                {
                    Console.Write(a); //Se for o último número (i == valores - 1): imprime apenas o número a, sem vírgula depois. ...8 
                   
                }
                c = a + b; //soma os dois últimos valores da sequência e armazena o valor na variável c
                a = b; // agora o a passa a ser o valor anterior de b
                b = c; // e b passa a ser o novo valor calculado( que estava em c ). Isso prepara os valores para a próxima iteração do 'for'.
            }
            Console.ReadKey();





        }
    }
}
