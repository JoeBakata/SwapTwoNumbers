using System;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print name, version and name of creator in cyan.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tSwapTwoNumbers\tVer 1.0\tcreated by JB");

            // Console foreground color back to default.
            Console.ForegroundColor = ConsoleColor.Gray;

            // Setup variables for first number, second number, and a spot to store a number.
            double num1, num2, temp;

            // Inform the user of the min and max values.
            Console.Write($"I am going to ask you for two numbers. Their values must be between {double.MinValue} and {double.MaxValue}\n");

            // Ask the user for the first number.
            Console.Write($"\nPlease enter the first number: ");// \n means newline.

            // Store the first number in the num1 variable.
            num1 = double.Parse(Console.ReadLine());// double.Parse() takes the Console.Readline(), which is a string, and changes it to a double.

            //Ask the user for the second number.
            Console.Write($"Please enter a second number : ");

            // Store the second number in the num2 variable.
            num2 = double.Parse(Console.ReadLine());

            // Change the Console.Foreground color.
            Console.ForegroundColor = ConsoleColor.Green;

            // Tell the user what they entered for first number.
            Console.Write($"\nYou entered {num1} for first number,");

            // Change the Console.Foreground color.
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Tell the user what they entered for the second number.
            Console.Write($"\nand {num2} for the second number.");

            // Swap the numbers.
            temp = num1;// Put num1 value into temp.
            num1 = num2;// Put num2 value into num1.
            num2 = temp;// Put temp value, which used to be value for num1, into num2.

            // Show the user the numbers are now swapped.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\n\nThe First Number is now: {num1}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\nThe Second Number is now: { num2}\n");
            //Console.Read();// No longer needed to keep output on the screen.

            // todo2 make a way for the program to continue.
            // todo3 make a way to exit the program.
            // todo4 check for valid input

        }
    }
}
