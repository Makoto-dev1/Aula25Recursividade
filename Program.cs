using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade seq = new Recursividade();
            seq.GerarSequenciaFibonacci(0,1,10);
            System.Console.WriteLine("Tribonacci");
            seq.GerarSequenciaTribonacci(0,1,2,10);

            System.Console.WriteLine(seq.GerarFatorial(5));
        }
    }
}
