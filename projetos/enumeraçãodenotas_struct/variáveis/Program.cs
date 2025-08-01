using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variáveis
{
    class Program
    {
        enum Notas 
        {  
            Minimo = 10, //nomear e separar por virgula um valor do outro
            medio = 15,  //isso não é uma string portanto não coloque entre aspas
            maximo = 20
            

        }

        struct pessoa
        {
            public string nome; //public = define a visibilidade( não vai ficar vísivel nas nossas variáveis)
            public int idade; //estrutura(struct) tipo de valor que pode encapissular dados e funcionalidades relacionadas. criar estrutura de dados para armazenar valores relacionados a esse tipo.
            public double peso;
        }

        
        
            
        
        static void Main(string[] args)
        {
            Notas notasAlunos = Notas.medio; //podemos criar variaveis a partir da enumeração , podemos definir conforme os tipos de dados que temos.

            pessoa p1 = new pessoa(); // inicializar uma estrutura.
            p1.peso = 56;
            p1.idade = 21;
            p1.nome = "Gabrie";

            pessoa p2 = new pessoa() // nesse caso eu não preciso referenciar o objeto pq já estou dentro do escopo{}, apenas colocarei o nome dos campos
            {
                peso = 59,
                idade = 24,
                nome = "Filipe"
            };

            //a pessoa 1 e 2 são a mesma coisa porém eu só fiz de forma diferente
            
            p1.nome = " carlos"; // substitui gabrie por carlos

            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.peso);
            Console.WriteLine(p1.nome);

            Console.WriteLine(" ... ");

            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.peso);
            Console.WriteLine(p2.nome);

            //Exemplos de uso : condicionais, dias de semana, valores personalizados, convertendo enumeração para número e vice-versa, enumeração com switch.



















        }





    }
}

