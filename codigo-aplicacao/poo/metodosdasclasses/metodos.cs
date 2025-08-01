using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosdasclasses
{
    internal class metodos
    {
        //vamos usar para criar os diferentes tipos de métodos que podemos ter:
        
        //MÉTODO SIMPLES :
        /*public void cumprimentar()
        {
            Console.WriteLine(" olá , seja bem vindo");
        }
        
        //MÉTODO COM PARÂMETROS 
        public void somar(int num1, int num2) // o que tá entre parênteses são parâmetros(2)
        {
            int resultado = num1 + num2;
            Console.WriteLine(" resultado é " + resultado);
        }
        public void apresentar(string nome, int peso)
        { 
            Console.WriteLine(" meu nome é " + nome + " e meu peso é " + peso);
        }
        //passagem de parâmetros por valor 
        public void aumentarvalor (int valor) //Uma cópia da variável é passada para o método. O método mexe na cópia, e não altera a variável original.
        { 
            valor += 10;   // aqui o 'valor' é uma cópia da variável original
            Console.WriteLine(" Valor final (por valor) é : " + valor);
        }
        //passagem de valor por referência
        public void aumentarvalor2(ref int valor) //para fazer por referência é necessário colocar o ref para indicar 
        { // O método recebe uma referência (um "ponteiro") para a variável original. Ou seja, qualquer alteração feita no método afeta a variável original fora do método.
            valor += 10; // aqui o 'valor' é uma referência à variável original
            Console.WriteLine(" Valor final (por referência) é : " + valor);
        }
        //MÉTODO COM RETORNO DE VALORES{RETURN}
        public string nomecompleto (string nome, string sobrenome)
        {   //string nomecompleto = nome + "  " + sobrenome;
            //return nome completo;
            return nome + "  " + sobrenome; // precisamos colocar  o return caso contrário dará erro, esse resumiu os dois de cima.
        }
        public int codigo (char caracrete)
        {   //int codigo = (int)caractere; não precisei fazer a conversão pois nesse caso ele irá fazer a conversão implicita
            return caracrete;
        }
        public double valorpi() // podemos ter caso em que não há parâmetros
        {
            return 3.1415;
        } */
        //SOBRECARGA DE MÉTODOS(OVERLOADING) é praticamente criar vários métodos com o mesmo nome porém com parâmetros diferentes(quantidade,ordem ou tipo).
        public void cumprimentar(string nome)
        {
            Console.WriteLine(" olá " + nome);
        }
        public void cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            //"?:" isso é um operador ternário, se a condição for verdadeira, execute o que está depois do ? , caso seja falsa execute o que está depois do : 
            Console.WriteLine(mensagem);
        }
        public bool comparar(int num1, int num2)
        {
            return num1 == num2;
        }
        public bool comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }

    }
}
