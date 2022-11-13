using System;

namespace Aula_10{

    class Project{

        enum DiasSemana {Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};

        static void Main( ){

            //Passando o parâmetro do indice do conjunto 
            
            DiasSemana ds_00  = (DiasSemana)0;


            //Obtendo o indice de um parâmtro do conjunto

            int ds_01;

            ds_01 = (int)DiasSemana.Domingo;

            
            Console.WriteLine("O valor de d_00 é:"+ ds_00+ "! E seu indice é:"+ds_01);






                





        }







    }






}