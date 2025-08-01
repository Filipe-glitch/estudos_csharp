using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testequatro
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            sbyte num6 = 10; // num1 é nome da variavel(não pode iniciar com número e nem ser nome composto)
            sbyte numero; // O = é atribuição, tudo que estiver do lado direito será atribuido a variável declarada do lado esquerdo.
            numero = 100; // caso não tivesse as duas linhas de baixo o valor que iria aparecer no terminal seria esse.
            numero = 120;  // caso não tivesse a linha de baixo o valor que iria aparecer no terminal seria esse.
            numero = num6; // ele retoma o primeiro valor que é 10.
            Console.WriteLine(numero); //sem aspas caso contrário será declarado como string.


            sbyte num = 123;
            num = 126;          // fez com que o nome da variável fosse alterado.
            Console.WriteLine(num);

            double num1 = 45.3; // pode ter ou não o ponto no número. Na programação o ponto equivale a vírgula e quando executado ele virará uma vírgula.
            double num5 = 12452163151641541615;
            Console.WriteLine(num1);

            float num2 = 465; // ele vai ler pois não é decimal.
                              // float num3 = 46.5; //ele não irá ler pois é um decimal e ele precisa do f que indica que ele é um float
            float num4 = 465f; // irá ler pois o f está presente, o f pode ser maiúsculo ou minúsculo

            Console.WriteLine(num2 + num4);
            Console.WriteLine(num4 + num1);
            Console.WriteLine(num1 * num2);

            long num7 = -42556L; // é necessário o L no final 
            decimal num8 = 415111131541957.45m; //é necessário o m no final para o código funcionar

            bool verificar = false;
            Console.WriteLine(verificar);

            var arroz = 56.5356;  //o compilador determina o tipo de dado.
            var letras = " dmkdmkmdkmd ";
            Console.WriteLine(arroz);
            Console.WriteLine(letras);

            var valor = 100.45; // a variável valor foi definida como número real podendo ser float,double ou decimal
            valor = 20;
            // valor = "Gabriel"; // nesse caso teremos erro pois a variável valor já foi atribuida a um número real tornando impossível seu uso em string.

            object obj = false; //é object e não bool
            Console.WriteLine(obj); // object é a base para outros dados. Eu posso atribuir outros a qualquer momento diferente da var que se limita a um mesmo tipo de dado.
            obj = 456; // é object e não inteiro
            Console.WriteLine(obj);
            obj = " lmao"; //é object e não string
            Console.WriteLine(obj);
            Console.ReadLine();
            

            char num9 = 'k'; //ela armazena um único caractere.
            Console.WriteLine(num9); 
            Console.ReadLine();

            char letra = 'k';
            int codigoAscii = (int)letra;// convertendo a variável letra de char para int.Na tabela ASCII é 107.
            Console.WriteLine(codigoAscii); //codigoAscii é nome da variável 
            Console.ReadLine();

            int numero4 = 'c';
            Console.WriteLine(numero4);

        }
    }
}
