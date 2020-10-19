using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{

    class hierarchical
    {
        public static void Main()
        {
            b objl = new b();
            C obj2 = new C();
            objl.Show2();
            objl.Display();
            obj2.show1();

        }
    }
    class A
    {
        public void Show2()
        {
            Console.WriteLine("Welcome to the world of c#");
          
        }
    }
    class b : A //class B is derived by class A
    {
        public void Display()
        {
            Console.WriteLine("Hello");
        
        }
    }
    class C : A //class C is derived by class A
    {
        public void show1()
        {
            Console.WriteLine("How are You ?");
            Console.WriteLine("press any key to exit");
            Console.ReadLine();

        }
    }
   
}
