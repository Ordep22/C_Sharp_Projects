using System;

namespace Projeto{

    class project{


        static void Main(string [] args){

            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Olá Dev's");
            Console.WriteLine("Aula 10: Simples calculadora:");
            Console.WriteLine("Lets to code");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n");



            double num1,num2,res_sum,res_sub;
            string v_temp;


            for (int i = 0; i < 3; i++){   

                Console.WriteLine("Entre com o primeiro número:");
                v_temp = Console.ReadLine();
                num1 = int.Parse(v_temp);




                Console.WriteLine("Entre com o segundo número:");
                v_temp = Console.ReadLine();
                num2 = int.Parse(v_temp);


                res_sum = num1 + num2;
                res_sub = num1 - num2;





                if (res_sum< 5 ){

                    Console.WriteLine("A soma dos números é menor que 5");

                }


                else if (res_sum > 5 && res_sum <=10){

                    Console.WriteLine("A soma do números está entre 5 e 10");

                }


                else if (res_sum > 10 && res_sum <= 15){

                    Console.WriteLine("A soma dos números está entre 10 e 15");
                }



                Console.WriteLine("A soma dos dois números é:"+ res_sum);

                Console.WriteLine("A subtração entre os dois números é:"+ res_sub);

            }




        }





    }





}