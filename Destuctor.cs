using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    class Destuctor
    {
        int id;
        int sal;
        String s;
        public Destuctor(int id,int sal,String s)
        {
            id = id;
            sal = sal;
            s = s;
            Console.WriteLine("id of employee :"+id+" the salary of employee : "+sal+"the name of employee :"+s);
            Console.ReadLine();
        }
        ~Destuctor()
        {
            Console.WriteLine("the object is destroyed");
            Console.WriteLine("press any key to exit");
                 Console.ReadLine();
        }

    }
    class solution
    {
        public static void Main(String[] args)
        {
            Destuctor ds = new Destuctor(12, 1500, "surendra");
        }
    }
}
