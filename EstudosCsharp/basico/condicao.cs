using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico
{
    internal class condicao
    {
        public static void condicaoteste()
        {
            //ESTRUTURAS CONDICIONAIS
            int numero2 = 0;
            string numero = "";

            Console.WriteLine(" Escolha um número "); //após digitarmos o número ele estará em string e precisamos converter ele em um número inteiro
            Console.WriteLine(" O número precisa ser maior que 12 para a condição ser verdadeira e menor ou igual a 12 para ser uma condição falsa");
            Console.WriteLine("------------------------------------------------------------");
            numero = Console.ReadLine();
            numero2 = Convert.ToInt32(numero);

            if (numero2 > 12)  // aqui temos a condição if, caso cumpra o que estiver escrito dentro dos parênteses aparecerá o que está escrito dentro das chaves do if
            {
                Console.WriteLine(" condição verdadeira");
            }
            else // caso não seja cumprida a condição que está entre parenteses do if , apareça o que está entre chaves do else. O ELSE NÃO ACEITA CONDIÇÃO, COLOQUE AS CONDIÇÕES NO IF OU IF ELSE
            {
                Console.WriteLine(" condição falsa");
            } // caso a condição if não seja cumprida e não tenhamos um "else" no código, não irá aparecer nada na tela.

            //ENCADEADAS 
            string letra = "";
            int num1 = 0;
            Console.WriteLine("ESPECIFICAÇÕES DA BRINCADEIRA ");
            Console.WriteLine("______________________________");
            Console.WriteLine("será verdadeiro caso o número seja menor que 10 ");
            Console.WriteLine("será quase verdadeiro quando o número for 10 e menor que 15");
            Console.WriteLine("será quase falso caso o número for 15 ou menor que 20");
            Console.WriteLine("será falso caso o número seja 20 ou maior que 20");
            Console.WriteLine("______________________________");
            Console.WriteLine("Agora, digite um número ");

            letra = Console.ReadLine();
            num1 = Convert.ToInt32(letra);

            if (num1 < 10) //caso não cumpra , ele verá cada else if na ordem colocada até chegar ao else  ou encontrar a condição que satisfaça
            {
                Console.WriteLine("VERDADEIRO");
            }
            else if (num1 >= 10 && num1 < 15)
            {
                Console.WriteLine("QUASE VERDADEIRO");
            }
            else if (num1 >= 15 && num1 < 20) //podemos ter vários else if porém tome cuidado com os valores e strings para não acabar interferindo no if
            {
                Console.WriteLine("QUASE FALSO");
            }
            else if (num1 >= 20)
            {
                Console.WriteLine("FALSO");
            }
            Console.ReadKey();

            //ALINHADAS
            int numero4 = 12;
            if (numero4 > 5)
            {
                Console.Write(" O número é maior que 5");
                if (numero4 % 2 == 0)  //é possível colocar quantos ifs vc quiser, desde a sua necessidade. Caso eu queira colocar mais especificações a partir dessa já especificação.
                {
                    Console.WriteLine(" é também par");
                }
            }
            else
            {
                Console.WriteLine(" é também ímpar ");
            }
            

            //OPERADOR TERMÁRIO , ele faz mais rápido o caso do if e else sem o if else.
            int numero5 = 12;
            string mensagem = "";
            mensagem = numero5 > 5 ? "Maior que 5" : "Menor que 5"; //condição ? true : false ;
            Console.WriteLine(mensagem);
            Console.ReadKey();
            //obs: nós poderiamos colocar esse operador termário dentro do writeline ou da própria string . ex: string mensagem = numero > 5 ? ...
            //esse "resumo" se equivale a isso daqui:
            /* if (numero > 5)
            {
                mensagem = " Maior que 5 ";
            }
            else
            {
                mensagem = "Menor que 5";
            }
            */
        }
    }
}
