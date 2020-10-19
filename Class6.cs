using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    class Class6
    {
        public readonly string name = "Suresh Dasari";

        public readonly string location;

        public readonly int age=30;
        

        public Class6(string name,String lc, int a)

        {
            name = name;
            location = lc;

            age = a;

        }

        

       
            }
    class Program1

    {

        static void Main(string[] args)

        {

            Class6 u = new Class6("suri","vijayawada",20);
          
            // This will throw compile time error


            Console.WriteLine("Name: {0}", u.name);

            Console.WriteLine("Location: {0}", u.location);

            Console.WriteLine("Age: {0}", u.age);

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }
    }
}
