using System;

namespace MathOperationApp
{

    class MathWorker
    {
        // Method that takes two integers as parameters
        public void ProcessNumbers(int num1, int num2)
        {
            //The method will perform a math operation on the 1st integer and will display the 2nd integer on screen
            int result = num1 * 2;
            Console.WriteLine("Result of math operation on first number: " + result);
            Console.WriteLine("Second number provided: " + num2);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //Intantiate class
            MathWorker MathOp = new MathWorker();
            //Calling the method and passing in two numbers
            MathOp.ProcessNumbers(5, 10);
            //Calling the method and spcifying the parameters by their name
            MathOp.ProcessNumbers(num1: 7, num2: 14);
            Console.ReadLine();
        }
    }
}


