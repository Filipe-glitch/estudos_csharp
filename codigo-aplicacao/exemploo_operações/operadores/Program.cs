using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operadores aritméticos
            
            Console.Write("15 + 54 = "); // a única coisa que muda é o fato de eu usar uma string para mostrar qual soma eu fiz para a pessoa
            Console.WriteLine(15+54);
            //ou 
            int resultado = 15 + 54;
            Console.WriteLine(resultado);
            //ou
            int num1 = 15;
            int num2 = 54;
            int resultado = num1 + num2; // resultado é apenas uma variável e não um código para fazer o procedimento matemático.
            Console.WriteLine(resultado);
            
            //ou
            int num1 = 15;  // prefira esse pois com esse você pode fazer outras operações com os mesmos números sem precisar copiar muito.
            int num2 = 54;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 * num2);  
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            //ordem de prioridade
            
            double num3 = 152;
            double num4 = 21; //primeiro o parênteses depois a multiplicação e divisão(caso tenha duas ou mais sem parênteses , a prioridade será da esquerda para direita e depois subração e soma.
            double num5 = 12;
            double res = (num4 + num3) * num5 / 3;
            Console.WriteLine(res);
            

            //operadores de decremento e incremento

            int num6 = 10;
            num6++; //isso equivale a num6 = num6 + 1; para esses casos podemos usar tanto o num6++ e ++num6. no caso abaixo teremos diferença
            Console.WriteLine(num6); //irá exibir o 11

            int num7 = 44;
            Console.WriteLine(num7++); //num7++ ele usa o valor atual e depois incrementa, ou seja, só no segundo console ele aplicará o operador para somar o valor.
            Console.WriteLine(num7);

            int num8 = 54;
            Console.WriteLine(++num8);
            Console.WriteLine(num8); // ++num8 nesse caso, ele incrementa antes de usar portanto os dois valores que irão sair serão iguais.
            
            //Concatenação 
            
            string nome = " gabrie ";
            string sobrenome = "artigas";
            string completo = nome + sobrenome + 1985; //podemos colocar números que eles serão tratados como string
            Console.WriteLine(nome + sobrenome); //ele vai juntar as strings e gerar uma só string
            Console.WriteLine(completo);
            
            //OPERADORES DE ATRIBUIÇÃO 

            int num9 = 14;
            num9 = num9 / 2; // usando atribuição : num9 = /= 2; 
            Console.WriteLine(num9);

            string nome2 = "Gabriel"; // esse += também serve para strings.
            nome2 += "Artigas";
            Console.WriteLine(nome2);
            
            //OPERADORES DE IGUALDADE
            bool res = 100 == 50 * 2;
            string nome = "Pabro";
            bool res2 = nome == "Pabro";
            Console.WriteLine(res);
            Console.WriteLine(res2);

            //OPERADORES RELACIONAIS 
            bool res4 = 100 < 50 * 2;
            bool res5 = 124 >= 46 + 45;
            Console.WriteLine(res4);
            Console.WriteLine(res5);

            int n1 = 45;
            int n2 = 65;
            int n3 = 98;

            Console.WriteLine(n1 + " > " + n2 + " = " + (n1 > n2));
            Console.WriteLine(n1 + " + " + n2 + " x " + n3 + " = " + (n1 + n2 * n3)); //um jeito diferente porém evite fazer dessa forma.

            //operadores lógicos 
            bool res6 = 100 > 50;
            bool res7 = 50 != 65;
            bool resul = res6 && res7; // && os dois precisam ser verdadeiro para aparecer a mensagem TRUE.
            bool resul2 = res6 || res7; // || um dos dois precisam ser verdadeiro para aparecer a mensagem TRUE.
            // ou bool resul2 = 100 > 50 || 50 != 65; por questões de facilidade de leitura use o método de cima.
            Console.WriteLine(resul);
            Console.WriteLine(resul2);


            //teste
            int numero1 = 215;
            string numero2 = "100";
            string resultado = numero1 + numero2;
            Console.WriteLine(resultado); // irá sair 215100 

            Console.ReadKey();
        }

        }
    }

