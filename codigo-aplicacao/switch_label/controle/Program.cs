using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
         //SWITCH,DEFAULT, BREAK E CASE
         double num = 4;
         switch (num) // executar diferentes blocos de código com base no valor de uma variável 
         {
         default: // a default será acionada caso a variável não se encaixe em nenhum dos casos.
         Console.WriteLine(" nenhuma opção ");
         break;
             case1: //caso a variável seja 1(double num = 1;) aparecerá o que está definido nesse código(opção 1).
                 Console.WriteLine(" opção 1");
                 break; //após cada case é necessário colocar um break pois o programa continuará executando os próximos casos.
             case2:
                 Console.WriteLine(" opção 2");
                 break;
             case3: //caso tivermos vários casos para um código podemos colocar dessa forma para pouparmos tempo. 
             case4: 
                 Console.WriteLine(" opção 3 e 4");
                 break;
        */

        //GOTO + LABEL 
             inicio: //aqui é para onde seremos transferidos caso cumpramos o que a guto pede.
             Console.WriteLine(" Escolha um número : ");
                    int op = int.Parse(Console.ReadLine());
                    int valor = 0;
                    switch (op)
                    {
                    default:
                    goto inicio; //isso significa que cada vez que colocarmos um valor que não esteja dentro dos casos, ele irá voltar aonde está a label inicio.
                    case 1:
                    valor += 100;
                    break;
                    case 2:
                    valor += 50; //porém nesse caso eu quero que some mais os 100 do primeiro caso. então para retomar um caso anterior nós colocamos o goto(não finalize vá para o caso1) ao invés do break
                    goto case 1; //existem outras formas de fazermos isso porém isso é somenté para aprendizado
                    }
             Console.WriteLine(" VALOR final " + valor); //use a goto para switch e case ou sair de loops ananhados complexos.
             Console.ReadKey();



            }
        }
    }

