using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    class Accessspecifier
    {
        class Program
        {
            static void Main(string[] args)
            {
                two B = new two();
                B.show();
            }
        }
        class one
        {
            private int x;
            protected int y;
            internal int z;
            public int a;
            protected internal int b;
        }
        class two : one
        {
            public void show()
            {
                Console.WriteLine("Values are : ");
               // x=10;
                y = 20;
                z = 30;
                a = 40;
                b = 50;
                //Console.WriteLine(x); // Error x is not accessible
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.ReadLine();

            }

        }
    }
}
