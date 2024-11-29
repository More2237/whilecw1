using System;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double count = 0;
            var result = a;
            if (a < b)
                Console.WriteLine("error!");
            while (result>=b)
            {
                result -= b;
                count++;
            }
          
            Console.WriteLine(count);
        }
        
        
        
    }
}