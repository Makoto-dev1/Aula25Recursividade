using System;

namespace Aula25Recursividade
{
    public class Recursividade
    {

        public void GerarSequenciaFibonacci(int num1, int num2, int vezes   ){
            //Condiçao crucial de parada da recursividade 
            if(vezes >= 0 ){
                System.Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }
        }
        
        public void GerarSequenciaTribonacci(int num1, int num2, int num3, int vezes ){
            
            if(vezes >= 0){
                System.Console.WriteLine(num1);
                GerarSequenciaTribonacci( num2 ,num1 + num2 + num3, num1, vezes - 1 );
            }
        }

        //Fatorial: 5!= 5 * 4 * 3 * 2 * 1
        public int GerarFatorial(int numero){
            Console.ForegroundColor =   ConsoleColor.Green;
            //condiçao pra quebrar a recursividade do método
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
        }
    }
}