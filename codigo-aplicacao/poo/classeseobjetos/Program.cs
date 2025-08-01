using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeseobjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region classe e objetos
            minhaaula aula = new minhaaula(); //aqui você está criando um objeto(instância) da classe minhaaula
            minhaaula aula2 = null; //referência nula, então não aponta para nenhum objeto
            //outraclasse outra = new minhaaula(); //dará erro pois eu tenho que definir os objetivos do mesmo tipo(mesma classe)
            outraclasse outra = new outraclasse();
            outraclasse outra2 = outra;
            // minhaaula é a classe , aula e aula2 são as variáveis de referÊncia(objetos da classe minhaaula) , new MinhaAula() é a Instanciação (chamada do construtor da classe)
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = " Filipe ";
            p1.sobrenome = " Mariano ";
            p1.AnoNascimento = 2001 ;
            // ou
            Pessoa p2 = new Pessoa()
            {
                nome = " Filipi ",
                sobrenome = " Marino ",
                AnoNascimento = 2000
            };
            p1.nome = " Felipe "; // a qualquer momento do código eu posso trocar o nome delas.
            Console.WriteLine(" Pessoa 1 :" + p1.nome);
            Console.WriteLine(" Pessoa 1 :" + p1.sobrenome);
            Console.WriteLine(" Pessoa 1 :" + p1.AnoNascimento);
            p1.cumprimentar();
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Pessoa 2 :" + p2.nome);
            Console.WriteLine(" Pessoa 2 :" + p2.sobrenome);
            Console.WriteLine(" Pessoa 2 :" + p2.AnoNascimento);
            p2.cumprimentar();
            Console.ReadKey();
            
             



        }
    }

    class minhaaula //essa é a forma como definimos uma classe( ela precisa estar dentro do namespace porém eu posso definir até dentro de outra classe)(classe sem começar por numero)
    {
        //aqui dentro ficará tudo que pertence a classe
        // não criamos a classe dentro do próprio arquivo de código fonte, criamos um arquivo separado para cada classe. é pósivel criar várias classe dentro do mesmo arquivo de código fonte.
        //vá em gerenciador de soluçôes, vá na classe (classeeobjetos), botão direito do mouse e clique em adicionar classe(dê outro nome e crie). e assim ele cria outro .cs 
        
    }

}

