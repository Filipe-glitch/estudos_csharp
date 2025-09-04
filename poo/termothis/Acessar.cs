using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termothis
{
    internal class Acessar
    { //TERMO THIS 
        string senha = " ABC 152 ";
        public bool login (string senha)
        {
            return this.senha == senha; //como dizer que esse primeiro senha(antes do ==) é o senha definido no começo(string senha). Utilizando o método this(ele vai fazer referência a classe onde está sendo instânciado).
        }                          // no caso a classe Acessar

        
    }
}
