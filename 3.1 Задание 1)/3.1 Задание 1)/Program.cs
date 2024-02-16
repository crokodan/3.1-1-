using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Задание_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int m = 50;
            for (; m != 0; m /= 10)
            {
                int r = m % 10;
                if (r > x) 
                { 
                    x = r; 
                }
                Console.WriteLine(x);
            }
        }
    }
}
