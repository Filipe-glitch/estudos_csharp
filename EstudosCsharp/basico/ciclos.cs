using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico
{
    internal class ciclos
    {
        public static void ciclosteste()
        {
            
            //WHILE // ele execta um bloco de códigos  repetidamente enquanto a condição for verdadeira.
            int valor = 0;
            while (valor < 11)  //o que está entre parenteses precisa ser verdadeiro para executar o comando que está entre chaves.
            {
                Console.WriteLine(" o valor é " + valor);
                valor++; //isso permitirá ter um limite para a estrutura, caso fosse só o códgo de cima ele iria ficar infinito sem parar
            }
            
            int valor2 = 45;
            while(valor2 > -45)
            {
                Console.WriteLine(valor2); //aqui o 45 se repetirá infinitamente !
            }
            int valor3 = 45;
            while (valor3 > 46)
            {
                Console.WriteLine(valor3); //aqui não aparecerá nada pois a condição não está sendo cumprida.
            }

            
            //DO-WHILE 
            //O DO faz com que o bloco de códigos seja executado pelo menos uma vez mesmo que seja falso.
            int num = 23;
            do
            {
                Console.WriteLine(" o valor é " + num); 
                num++;
            } while (num < 10);
            // o valor que sairá será 23( pois ele executa pelo menos uma vez mesmo que seja falso a condição while) mas caso eu fizesse isso apenas com o while , não teria nenhum retorno no terminal.
            
            
            // ESTRUTURA DE CONTROLE FOR
            // FOR( inicialização; condição; incremento){ será exibido o que está aqui enquanto a condição for verdadeira}
            for(int num1 = 0, num2 = 24 ;num1 < 12; num1++,num2-- )
            {
                Console.WriteLine(" NÚMEROS TEST " + num1); //por esse teste é possível ver que ele coloca o primeiro e depois colocar o de baixo e vai fazendo assim até um acabar e ficar só esse.
                Console.WriteLine(" números test " + num2);
            }
            Console.ReadKey();
           

            // CICLO FOREACH(ele executa um bloco de comandos a cada interação com uma estrutura.A cada passagem ele vai tirar um elemento daquela coleção e vai executar o bloco de código até chegar ao final da coleção.
            string[] frutas = { " apple ", "orange ", "avocado", " lemon ", "stawberry " }; 
            foreach (string fruits in frutas) //foreach(TIPO DE DADO logo após vem o ITEM e depois IN + VARIÁVEL do conjunto) 
            {
                Console.WriteLine("fruits in English " + fruits);
               // Console.ReadKey(); // o readkey estando aqui , ele vai pegar uma string a cada enter que eu apertar 
            }
            Console.ReadKey(); // aqui estarão todas as strings e o enter indicará o fim da solução.

        }
    }
}
