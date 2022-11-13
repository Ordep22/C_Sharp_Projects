using System;

namespace Aula_11{

    class Project{

        static void Main(){


            //Conversão de float para inteiro
            float n2 = 10.5f;
            int n3 = (int)n2; // ---> Essa forma é uma opreção de typecast 
                                // ---> Basicamente nesta cinversão são deixados os pontos flutuantes

            Console.WriteLine(n3);

            //Converão de vInt em vShort
          
            int v01 = 10;
            short v02 = (short)v01;

            Console.WriteLine("A conversão foi bem sucessedida. O valor de v02 é: "+v02);
            








        }




    }



}