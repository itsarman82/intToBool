using System;

namespace intToBool
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a simple application to convert a string to a boolean

            Console.WriteLine("enter the value of the boolean");

            string userInput = Console.ReadLine();
            Console.WriteLine(userInput.GetType());

            // get an input from user and get the value type

            bool output = Convert.ToBoolean(userInput);
            Console.WriteLine(output);
            Console.WriteLine(output.GetType());

            // convert the value to a boolean and return the value type
        }
    }
}
