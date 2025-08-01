using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termothis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar A = new Acessar(); // O A é objeto da classe Acessar 
            if (A.login("ancbdvjf")) //o que está aqui é a senha , se eu colocar a senha que está lá aparecerá  o acesso permitido.
            {
                Console.WriteLine("Acesso permitido"); //isso é facilmente um método para login
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
            Console.ReadKey();
        }  
    }
}
