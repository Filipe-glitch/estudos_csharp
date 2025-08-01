using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //VETOR / ARRAY UNIDIMENSIONAL
            /*
            int[] numeros = new int[4]; //os colchetes declaram que nós estamos definindo vetores. Precisamos desse new . coloque dentro do segundo colchetes a quantidade de posições que vc quer(máximo de elementos)
                                        //agora para definir os valores desse vetor

            numeros[0] = 12; // sempre comece pelo zero e vai até o número anterior ao que vc colocou
            numeros[1] = 15; //lembre-se que precisam ser do mesmo tipo
            numeros[2] = 18;
            numeros[3] = 21;

            numeros[2] = 45; // aqui eu alterei o valor dessa posição
            Console.WriteLine(numeros[2]);

            string[] materias = new string[3];
            materias[0] = "matematica";
            materias[1] = "ingles";
            materias[2] = "programação";
            Console.WriteLine(materias[2]);
            // há uma outra forma de definir os vetores tanto as strings quanto o números. veja em baixo !
            
            string[] materias1 = 
            { 
            "matematica", 
            "ingles",  // usamos as chaves para declarar os valores dos vetores e separamos por vírgula cada valor que queremos dar ao vetor em ordem, o compilador irá ver quantos elementos há e irá contar automatico.
            "programação" // lembre-se que deve colocar em ordem.
            };
            Console.WriteLine(materias1[1]);
            Console.ReadKey();
            

            //MATRIZ / ARRAY BIDIMENSIONAL

            int[,] numero = new int[2, 3]; //a primeira vírgula define que se trata de uma array bidimensional. a segunda virgula separa quantas linhas e colunas terão.
            //do lado esquerdo é a quantidade de linhas e do lado direito é a quantidade de colunas.

            numero[0, 0] = 21;
            numero[0, 1] = 22;
            numero[0, 2] = 23;
            numero[1, 0] = 24;
            numero[1, 1] = 25;
            numero[1, 2] = 26;
            numero[1, 1] = 12; //aqui eu alterei o valor de uma delas.
            Console.WriteLine(numero[1, 2]);

            Console.Write("[" + numero[0, 0] + "]");
            Console.Write("[" + numero[0, 0] + "]");
            Console.Write("[" + numero[0, 0] + "]");
            Console.WriteLine();
            Console.Write("[" + numero[0, 0] + "]");
            Console.Write("[" + numero[0, 0] + "]");
            Console.Write("[" + numero[0, 0] + "]"); //isso é apenas para vc ver como seria isso numa matriz
            //há outra forma de definir os valores, veja abaixo:
            string[,] nomes =
            {
                {" Gabriel", "Marcos", "Carlos", "natã" }, //essa daqui é a primeira linha[0,...]
                {" daniel","Damasco","Alan","Rafael"}
            };
            Console.WriteLine(nomes[0, 3]);
            
            */
            string[,] frutas = new string[3, 4]
            {
                { "abacate", "morango", "limão", "doces"},
                { "uva", "manga", "geus" , "fhfh" },
                { "feo", "ddtgfdh" , "djfj", "dudnfdi" }
            };
            Console.WriteLine(frutas[2,3]);
            Console.ReadKey();
            


        }
    }
}
