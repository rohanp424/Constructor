using System;

namespace Reference
{
    class Program
    {

        static public void Main()
        {

            int s = 60;

            Console.WriteLine(s);
            int a,b;


            Sum(out a, out b);

            Console.WriteLine("The sum of" + " the value is: {0}", a);
            Console.WriteLine("The sum of" + " the value is: {0}", b);
            Program c = new Program();
            Program d = new Program(2, 4);

        }

        //constructor without parameter
        Program()
        {
            int j = 10;
            Console.WriteLine("Constructor out is" + (j + 10));
        }

        //constructor overloading
        Program(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Constructor overloading output is " + c);
        }

        //ref
        //static void SetValue(ref int s)
        //{
        //    s = 60;
        //    s = s + 1;
        //    s = 0;
        //}

        //out
        public static void Sum(out int a, out int b)
        {
            a = 80;
            a += a;
            b = 60;
        }
    }
}

