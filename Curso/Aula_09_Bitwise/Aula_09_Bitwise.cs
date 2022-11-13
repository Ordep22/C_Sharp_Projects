using System;

    namespace Projeto{

    class Projetc{


        static void Main(){

            /*
            A ferramente de bitwise quando deslocado a esquerda dobra o valor do parâmetro informado 
            int a  = 10, b = 0/
            b = a << 1;

            Console.WriteLine(b);
            
            SAÍDA DO CONSOLE:

            20
            ----------------------------
            Quando delocada a direita divide a valor da variável pela metade

            int a  = 10, b = 0/
            b = a >> 1;

            Console.WriteLine(b);
            
            SAÍDA DO CONSOLE:

            5 
            */


            int num_01 = 10,num_02,num_03;
            string a  = "oi",b = "";

            Console.WriteLine("O número é: "+num_01);
            
            b = a << 1;

            num_02 = num_01<<1;

            Console.WriteLine("O número deslocado a esquerda em  um bit é: "+b);

            num_03 = num_01 >> 1;

            Console.WriteLine("O número delocado a direita em uma unidade é: "+num_03);



        }   

    }

}