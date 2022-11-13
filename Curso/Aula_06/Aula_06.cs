using System;

namespace Aula_06{


    class projetc{

        static void Main (string [] args ){

            Console.WriteLine("------------------------------");
            Console.WriteLine("Olá Dev's");
            Console.WriteLine("Aula 06: Tipos de dados");
            Console.WriteLine("Lets to code");
            Console.WriteLine("------------------------------");


            //Tipos de dados no C#

            /*

                Inteiros: 1,2,3,4
                doble: 1.55, 6.45
                float: 1.55f, 6.45f
                string: "Escrevemso dentro das aspas"
                Booleano: true or false

            */


            //Variáveis do tipo inteiro
            int a = 10;
            int b = a +1;


            Console.WriteLine(a);
            Console.WriteLine(b);

            //Variável do ponto flutuante
            //As variávis do tipo flutuante pode ser doble ou float

            double c = 1.43;
            double d = -0.987655+ c;

            //No caso das floats devemos declarar da seguinte maneira

            float e = 1.567f;
            float f = 4.65f;

        
            Console.WriteLine("Variáveis do tipo doble:");
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("Variávsi do tipo float");
            Console.WriteLine(e);
            Console.WriteLine(f);

            // A diferença entre a aplicação entre a atulização das variáveis doble e float é:

            // As variáveis float podem ser utilizadas no intervalo de -3.4X10ˆ38 até 3.4X10ˆ28

            //As variáveis doble podem ser utlizadas no intervalo de -3.4X10ˆ38 até 3.4X10ˆ28

            // A diferença entre as duas está na capacidade de armazenamento de informações

            //No entanto as variávies DOBLE consomem mais memória (64bits) que as FLOAT (32bits)


            //Para números maiores é possível utilizar as variáveis Long

            // Mas em comparação aos dados Log eles consomem somente 32bits de memória enquanto os Long ocupam 64bits

            // Tipo byte 
            //Compreende uma baixa faixa 0 até 255
            //Mas são exelentes para armazenar valores de cíclos

            byte g = 0;
            








        }




    }




}
