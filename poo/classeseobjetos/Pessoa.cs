using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeseobjetos
{
    internal class Pessoa
    {// atributos são as variáveis que vão fazer parte do escopo principal ,ou seja, aqui dentro.
        public string nome; //esses campos são variáveis que definem os atributos dos objetos derivados dessa classe, eu posso definir quantos atributos eu quiser
        public string sobrenome; // em azul são os atributos e em branco são os campos
        public int AnoNascimento;
        //public torna eles disponiveis e acessiveis para todos os objetos disponiveis dessa classe
        //método simples
        public void cumprimentar () //o parentêses indica que não há parâmetro
        { 
         Console.WriteLine (" OLÁ, eu sou o " + nome + sobrenome);
        }
    }
}
