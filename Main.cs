using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplying
{
    class CalculatingProductOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int p;
            Console.Write("Please input a value for X:");
                x=Convert.ToInt32(Console.ReadLine());
                Console.Write("Please input a value for for y:");
                y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input a value for z:");
                z= Convert.ToInt32(Console.ReadLine());
                p = x * y * z;
            Console.WriteLine("The product of x,y and z is " + p);
        }
    }
}
