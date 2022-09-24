using System;
namespace Aula_05{

    class Project{

        static void Main (string [] args){

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Olá Dev's");
            Console.WriteLine("Aula_05:Estudos das variáveis");
            Console.WriteLine("Let's to code!");
            Console.WriteLine("-------------------------------------------");

            /*
            Variáveis são locais na mem´øria que reservamos para armazenar um valor 

                1) Um nome de cliente 
                2) Quantidade de um produto no estoque 
                3) Hora do sistema 
                4) Usuário que está logado 
            */

            
            //Variável do tipo inteiro 
            int num = 100;
            // As variáveis int no C# será atribuido um valor zero à essa identificação

            Console.WriteLine("O valor da variável INTEIRA é:");
            Console.WriteLine(num);

            //Variável booleana

            bool n_logico  = true;

            Console.WriteLine("O valor da variável booleana é:");
            Console.WriteLine(n_logico);

            //Variável de strings
            //Quando comparado o C# com o C++ percebe-se que é mais simples trabalhar com string

            string nome  = "Pedro";

            Console.WriteLine("O nome do progranador é:");
            Console.WriteLine(nome);










    
        }

    }

}