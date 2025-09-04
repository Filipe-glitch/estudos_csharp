using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosdasclasses
{
    internal class Program
    {
        static void Main(string[] args)
        { //vou criar uma instância da classe métodos
            metodos m = new metodos();
            /*
            m.cumprimentar(); //aqui por ser sem parâmetros não precisa colocar nada nos parênteses.
            m.somar(12, 65); // aqui ele pede os dois números inteiros que defini nos parâmetros. posso usar as variáveis também.
            m.apresentar(" Filipe ", 65);


            int valor1 = 100, valor2 = 100;
             
            m.aumentarvalor(valor1); 
            m.aumentarvalor2(ref valor2); //lembre-se que precisamos colocar o ref para definir que se trata desse tipo de caso
            Console.WriteLine(" valor 1 = " + valor1); // ainda 100
            Console.WriteLine(" valor 2 = " + valor2); // agora 110
            Console.ReadKey();
           

            //MÉTODO COM RETORNO DE VALORES(RETURN)
            string nomecompleto = m.nomecompleto("Filipe", "Mariano");
            int codigochar = m.codigo('d');
            double pi = m.valorpi();
            Console.WriteLine(nomecompleto);
            Console.WriteLine(codigochar);
            Console.WriteLine(pi);
            Console.ReadKey();  
            */
            m.cumprimentar(" Filipe ");
            m.cumprimentar(" bea ", 12);
            bool res1 = m.comparar(12, 6 + 6); //essas duas não tem impressão de mensagens, então devemos colocar.
            bool res2 = m.comparar(" Andre ", " andre ");
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
