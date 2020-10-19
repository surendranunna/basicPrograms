using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    class Operators
    {
        static void Main(string[] args)

        {

            int x = 5, y = 10, result;

           /* result = x & y;

            Console.WriteLine("Bitwise AND: " + result);

            result = x | y;

            Console.WriteLine("Bitwise OR: " + result);

            result = x ^ y;

            Console.WriteLine("Bitwise XOR: " + result);

            result = ~x;

            Console.WriteLine("Bitwise Complement: " + result); */

            result = x << 3;

            Console.WriteLine("Bitwise Left Shift: " + result); 

            result = 10 >> 2;

            Console.WriteLine("Bitwise Right Shift: " + result);

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();

        }
    }
}
