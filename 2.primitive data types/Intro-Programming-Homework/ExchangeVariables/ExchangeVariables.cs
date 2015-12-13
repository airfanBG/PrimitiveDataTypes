using System;

    class ExchangeVariables
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = a + b;
            a = c - a;
            b = c - b;
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }

