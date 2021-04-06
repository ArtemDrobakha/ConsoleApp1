using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace ConsoleApp1
{
    class Program
    {
        class Mytimer
        {
            delegate int IntOperation(int i, int j);
            static IntOperation op;
            static bool a = true;
            public static int Sum(int x, int y)
            {
                return x + y;
            }

            public static int Prz(int x, int y)
            {
                return x * y;
            }
            public static void TimerCallback(Object o)
            {
                if (a==true)
                {
                    op = Sum;
                }
                else
                {
                    op = Prz;
                }
                Console.WriteLine("Результат: " + op(3,3));
                a = !a;
            }
        }
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("t=");
            t = Convert.ToInt32(Console.ReadLine());
            Timer timer = new Timer(Mytimer.TimerCallback, null, 0, t);
            Console.ReadKey();
        }
    }
}
