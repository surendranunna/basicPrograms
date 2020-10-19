using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace basicPrograms
{
    class MultiThread
    {

        public static void Main(String[] args)
        {
            Thread t1 = new Thread(new ThreadStart(displayinfo1));
            Thread t2 = new Thread(new ThreadStart(displayinfo2));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        public static void displayinfo1()
        {
            for(int i=0;i<=4; i++)
            {
                Console.WriteLine("the value of first thread {0}",i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("first method is complted");
        }
        public static void displayinfo2()
        {
            for (int i = 0; i <= 4; i++)

            {
                Console.WriteLine("the value of second thread {0}", i);
                Thread.Sleep(500);
            }

            Console.WriteLine("second method is complted");
        }

    }
}
