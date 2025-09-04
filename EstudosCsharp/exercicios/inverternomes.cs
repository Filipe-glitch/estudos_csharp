using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class inverternomes
    {
        public static void inverternomestest()
        {
            // 4 variáveis, cada uma terá um nome.E dali a pessoa digitará um nome para colocar nas variaveis e na hora de exibir vamos trocar/inverter os valores atribuidos as variaveis.
            string nome1, nome2, nome3, nome4, auxiliar; //variáveis do mesmo tipo, então podemos destacar assim.

            Console.Write("Digite o nome #1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome #2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o nome #3: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o nome #4: ");
            nome4 = Console.ReadLine();
            // isso tudo até aqui estavámos dando os valores as strings

            //agora colocaremos o mecanismo para inverter os nomes(existe outra forma além dessa porém essa daqui é para treinarmos a lógica de programação

            auxiliar = nome1; // tem a variável auxiliar onde vou colocar o primeiro nome, daqui ele ficou salvo ...
            nome1 = nome4; // então já posso colocar o quarto nome no primeiro para inverter a ordem . feito isso eu liberei a variável 4. então o nome que será colocado na variável 4 era o primeiro nome digitado que...
            //... que é para ficar em último. sendo assim o primeiro que foi digitado está guardado na variável auxiliar então foi atribuido na variável 4.
            nome4 = auxiliar;

            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;

            Console.WriteLine();
            Console.WriteLine(" nomes inseridos na sequência invertida ");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadKey();

        }
    }
}
