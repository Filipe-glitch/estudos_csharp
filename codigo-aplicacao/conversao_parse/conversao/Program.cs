using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //Conversão implícita
            
            byte num1 = 120; //8 bits, de 0 a 255
            ushort num2;   // 16 bits, de 0 a 65.535
            float num3 = 1051.4f;
            //nota-se que o espaço de memória da ushort é maior que a byte e que a ushort tem todos os números que a byte tem.
            // ou seja, se precisar armazenar um valor byte na variável ushort o compilador irá aceitar pois a ushort abrange todos os números da byte

            num2 = num1; // lembre-se que não é igualdade ! É atribuição, tudo que estiver do lado direito será atribuido a variavel do lado esquerdo. 
            // Se inverter dará erro pois uma variável byte não pode atribuir uma variável ushort.
            num3 = num1; // mesmo sendo real, ele pode assumir os valores de byte.

            //Conversão explícita

            ushort num4 = 100;
          //byte num5 = num4; nesse caso dará erro pois não é possível fazer a conversão implicita.
            byte num5 = (byte)num4; //devemos colocar o tipo de dado entre parênteses que queremos que seja convertido( conversão explícita)

            float num6 = 452.682f;
            int num7 = (int)num6; 
          //int num7 = (int)452.682f; assim também dará certo !!

            char letra = (char)97;

            Console.WriteLine(num7);

            //método parse
           
            string txtnumero = "1985";
            int numero = int.Parse(txtnumero);

            byte num = byte.Parse("156");
            double num8 = double.Parse("151546,45"); //o limite é 32 bits porém eu posso usar o tipo de dado double desde que o dado não ultrapasse o limite feito pelo método parse
            float num9 = float.Parse("4154153,4");

            Console.WriteLine(num8); */

            string text = Convert.ToString(2555);
            double num10 = Convert.ToDouble(false);
            double num11 = Convert.ToDouble('C'); // ESSE daqui dará erro pois a máquina tentará converter os valores mas nem sempre vão conseguir.
            Console.WriteLine(text);
            Console.WriteLine(num10);

            Console.ReadKey();
              

        }
    }
}
