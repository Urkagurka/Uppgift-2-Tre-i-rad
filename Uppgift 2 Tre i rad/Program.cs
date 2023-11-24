using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Skriv hur mycket N är värt");
            int N = int.Parse(Console.ReadLine());
            int j = 0;
            
            for (int i = 1; i * (i + 1) * (i + 2) < N; i++)
            {
                int E = i * (i+1) * (i+2);
                Console.WriteLine(E);

                j++;
            }
            Console.WriteLine("Det finns " + j + " stycken treiga tal under " + N);
        }
    }
}