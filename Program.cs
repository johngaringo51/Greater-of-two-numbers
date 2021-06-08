using System;

namespace Greater_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Please enter first number");
            number1 = Convert.ToInt32(Console.ReadLine()); //This statement is converting into int

            Console.WriteLine("Please enter second number");
            number2 = Convert.ToInt32(Console.ReadLine()); //This statement is converting into int

            if (number1 > number2)
            {
                Console.WriteLine(number1.ToString() + " is greater than " + number2.ToString());
            }
            else
            {

            }
            Console.WriteLine("Number 2 is greater number");
        }
    }

}
