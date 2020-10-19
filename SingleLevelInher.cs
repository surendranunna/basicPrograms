using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    class SingleLevelInher
    {
            public void show()
            {
                Console.WriteLine("Welcome to the world of C#");
                Console.ReadLine();
        }
        }
        class B : SingleLevelInher //class B is derived by class SingleLevelInher
    {
            public void display()
            {
                Console.WriteLine("Hello");
                 Console.Read();
        }
        }
        class single
        {
            public static void Main()
            {
                B obj = new B();
                obj.show();
                obj.display();
            }



        }
}
