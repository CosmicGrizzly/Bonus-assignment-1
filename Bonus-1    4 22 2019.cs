using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGrade;

            Console.WriteLine("Welcome to the Letter Grade Converter!");
            string willContinue = "y";
            while (willContinue == "y")
            {
                Console.WriteLine(" Please enter a numerical grade");
                numGrade = Convert.ToInt32(Console.ReadLine());

                // Once something is true it enters into the next block of code. Block of code ='s {}
                if (numGrade <= 100 && numGrade >= 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (numGrade <= 87 && numGrade >= 80)
                {
                    Console.WriteLine("Letter Grade B");
                }
                else if (numGrade <= 79 && numGrade >= 67)
                {
                    Console.WriteLine("Letter Grade C");
                }
                else if (numGrade <= 66 && numGrade >= 60)
                {
                    Console.WriteLine("Letter Grade D");
                }
                else if (numGrade <= 59 && numGrade >= 0)
                {
                    Console.WriteLine("Letter Grade F");
                }
                Console.WriteLine("Would you like to continue? (y/n) ");
                willContinue = Console.ReadLine();
            }
            //Telling the user Goodbye.
            Console.WriteLine("Grading Complete, Goodbye!");
        }
    }
}
