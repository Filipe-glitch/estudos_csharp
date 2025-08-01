using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_comandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // como funciona #region , aperte a setinha v ou >
            #region example

            Console.WriteLine("Hello, World!");
            Console.WriteLine(" hello friends ");
            Console.WriteLine(" how are you guys? ");
            Console.WriteLine(" I'm fine and happy");
            #endregion

            Console.Clear(); // ele limpa toda a tela do console(vai tirar tudo que foi digitado anteriormente).

            Console.Write(" olá e ");          //sem pular linha pro próximo
            Console.WriteLine("seja bem vindo");

            Console.WriteLine(10 + 10);      //máquina irá calcular
            Console.WriteLine(" 10 * 10 ");  // máquina não irá calcular pois se trata de uma string e não uma operação.

            Console.WriteLine(" 2 x 1 = " + (2 * 1));   // o + indica que o que vier depois ficará na mesma linha

            string text = " FMR \n adoro ser";   // \n é usado para quebrar linha. Então o que vier depois do \n ficará na linha seguinte.
            Console.WriteLine(text);

            string text2 = @"FMR \n adoro ser";     // o @ é usado para anular código especial, vai tratar tudo como caractere individual.

            string text3 = "babri";
            string mensagem = null;      // desnecessario porém entenda que é possivel trocar o valor do código
            mensagem = text3;
            Console.WriteLine(mensagem);       //vai sair babri
            Console.ReadKey();

            string nome = "";          //desnecessario pois o Consle.ReadLine já atribuirá um valor a variável.
            string a = "dasdas";
            Console.WriteLine(" olá, seu nome é?");
            Console.Write("digite seu nome ...");
            nome = Console.ReadLine();     //lê os dados que o usúario digitou e toda vez que o enter for pressionado ele traz os dados para o programador
            Console.WriteLine(" {0} {1} bem vindo", nome, a);         //{0} e {1} são marcadores, prefira interpolação. o {0} será trocado pelo que vier depois da primeira vírgula.
                                                                      //O {1} será trocado pelo que vier depois da segunda vírgula e assim por diante
            Console.ReadKey();         //irá sair o nome que colocar + dasdas bem vindo


            const int num11 = 456;  // o dado colocado nessa constante(const) nunca irá mudar
            Console.WriteLine(num11);


            int codigo = Console.Read(); // digitei a e apertei enter,aparecerá o decimal 97 (valor do caractere na base 10) , porém se eu digitar abc , ele só irá considerar o primeiro.
            //Retorna o código ASCII desse caractere como um número inteiro(int).
            Console.WriteLine(codigo);



            String texto = Console.ReadLine();
            Console.WriteLine(texto); //nesse caso eu quero transmitir valores que estão dentro das variáveis, portanto não coloco as aspas.



            string nome2 = "";
            Console.WriteLine("olá, qual é o seu nome?");
            nome2 = Console.ReadLine();
            Console.WriteLine(nome2 + " Bem vindo!");
            Console.ReadKey();

        }
    }
}
