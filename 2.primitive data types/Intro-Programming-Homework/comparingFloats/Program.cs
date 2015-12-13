using System;

    class comparingFloats
    {
        static void Main()
        {
            double firstNumber =  5.00000007;
            double secondNumber = 5.00000003;
            double difference =   Math.Abs(firstNumber*0.000001);
            if(Math.Abs(firstNumber-secondNumber)<=difference)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");
        }
    }

