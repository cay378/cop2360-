//Make a program that calculates two values. Program exceptions to display error messages
using System;

namespace DivisionExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recieving value from user
            Console.WriteLine("Enter a number value:");
            string number1 = Console.ReadLine();

            Console.WriteLine("Enter a number value:");
            string number2 = Console.ReadLine();

            try
            {
                //Converting user values from string to integers
                int value1 = Convert.ToInt32(number1);
                int value2 = Convert.ToInt32(number2);

                //Calculation used to get total
                int total = Divide(value1, value2);
                Console.WriteLine($"The final total of {value1} divided by {value2} is: {total} ");
            }
            //Exception if 0  is used
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
                Console.WriteLine($"Detailed error: {ex.Message}");
            }
            //Execption in user didn't input number values
            catch (FormatException ex)
            {
                Console.WriteLine("One or both values used are not valid integers.");
                Console.WriteLine($"Detailed error: {ex.Message}");
            }
            //Exception if user used to large of a number
            catch (OverflowException ex)
            {
                Console.WriteLine("The value used was too big. Please pick a smaller value.");
                Console.WriteLine($"Detailed error: {ex.Message}");
            }
            //Exception for general errors
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occured.");
                Console.WriteLine($"Detailed error: {ex.Message}");
            }

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    
    static int Divide(int a, int b)
    {
        return a / b;
    }

    }
}