
using System;

using System.Text;

using System.Threading.Tasks;
 
namespace Calculator

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int num1;

            int num2;

            int result = 0; 

            string answer;

            Console.WriteLine("Hello, welcome to the calculator program");

            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number.");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");

            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division.");

            answer = Console.ReadLine().ToLower();

            if (answer != null)

            {

                Console.WriteLine(answer);

            } 

            else 

            {

                Console.WriteLine("Invalid input"); 

            }

            if (answer == "a")

            {

                result = num1 + num2;

            }

            else if (answer == "s")

            {

                result = num1 - num2;

            }

            else if (answer == "m")

            {

                result = num1 * num2;

            }

            else if (answer == "d")

            {

                if (num2 != 0)

                {

                    result = num1 / num2;

                }

                else

                {

                    Console.WriteLine("Error: Cannot divide by zero!"); 

                    Console.WriteLine("Thank you for using my calculator program");

                    Console.Read();

                    return; 

                }

            }

            else

            {

                Console.WriteLine("Invalid operation!");

                Console.WriteLine("Thank you for using my calculator program");

                Console.Read();

                return;

            }

            Console.WriteLine("The result is " + result);

            Console.WriteLine("Thank you for using my calculator program");

            Console.Read();

        }

    }

}
 
