using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    class Demo
    {
        public static void Main(String[] args)
        {
            String s1 = "123";
            String s2 = "123";
            int n1 = s1.Length;
            String str = "";
            for (int i = n1 - 1; i >= 0; i--)
            {
                // Do school mathematics, compute sum of  
                // current digits and carry  
                int sum = ((int)(s1[i]-'0' ) +
                        (int)(s2[i]-'0') );
                str = str + sum;
               
            }

            String str2 = "";
           for (int i=str.Length-1;i>=0;i--)
            {
                 str2 = str2 + str[i];
            }
            Console.WriteLine(str2);
            Console.ReadLine();

        }

    }
}
