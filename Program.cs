/*
 * Author: Magaly Rodriguez
 * Course: COMP-003A
 * Purpose: Lecture activity 3, conditional statements
 */

namespace COMP003A.lectureactivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Conditional (selection) statements");
            Console.WriteLine("******************************************");
            /**************************************************************/

            Console.WriteLine("1. single if statement");
            Console.Write("\tEnter a whole positive number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine()); //stores user input as an integer

            //single if statement
            if(inputNumber % 2 == 0)
            {
                   //code will execute if the condition is true. 
                Console.WriteLine("\tinputNumber is even.");
            }

            /**************************************************************/
            Console.WriteLine("2. if-else statement");
            //if-else statement
            if (inputNumber % 2 == 0)
            {
                //this code block executes if the condition about is true
                Console.WriteLine("\tinputNumber is even.");
            }
            else
            {
                //this code block executes if the above condition is false
                Console.WriteLine("\tinputNumber is odd.");        
            }

            /**************************************************************/
            Console.WriteLine("3. nested if statement");
            //nested if statements
            if (inputNumber % 2 == 0)
            {
                //this code block executes if inputNumber is divisible by 2 
                Console.WriteLine("\tinputNumber is even.");

                if (inputNumber % 5 == 0)
                {
                    //this code block executes if inputNumber is divisible by 2 first, and divisible by 5 after
                    Console.WriteLine("\t\tinputNumber is also divisible by 5.");
                }
                else
                {
                    //this code block executes if inputNumber is divisible by 2 first but NOT divisible by 5 after
                    Console.WriteLine("\t\tinputNumber is NOT divisible by 5.");
                }
            }
            else
            {
                //theis code block executes if inputNumber is NOT divisible by 2
                Console.WriteLine("\tinputNumber is odd.");
            }
            /**************************************************************/

            Console.WriteLine("4. multiple if-else statements");
            if (inputNumber % 2 == 0)
            {
                //the code block executes if the above condition is true. the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 2.");
            }
            else if(inputNumber % 3 == 0)
            {
                //the code block executes if the above condition is true, the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 3.");
            }
            else if(inputNumber % 5 == 0)
            {
                //the code block will execute if the above condition is true. the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 5.");
            }
            else if(inputNumber % 7 == 0)
            {
                //this code block exeecutes if the above condition is true the rest of the conditions will no longer execute.
                Console.WriteLine("\tinputNumber is divisible by 7.");
            }
            else
            {
                //this code block executes if the above conditions are NOT true
                Console.WriteLine("\tinputNumber is NOT divisible by 2/3/5/7.");
            }

            /**************************************************************/

            int randomNumber = new Random().Next(10); //generates a random number 10 below
            Console.WriteLine("6. comparison operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} != {randomNumber}: {inputNumber != randomNumber}");
            Console.WriteLine($"\t{inputNumber} > {randomNumber}: {inputNumber > randomNumber}");
            Console.WriteLine($"\t{inputNumber} >= {randomNumber}: {inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} < {randomNumber}: {inputNumber < randomNumber}");
            Console.WriteLine($"\t{inputNumber} <= {randomNumber}: {inputNumber <= randomNumber}");

            /**************************************************************/

            Console.WriteLine("7. logical operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} && {inputNumber} >= {randomNumber}: "
                + $"{inputNumber == randomNumber && inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} || {inputNumber} >= {randomNumber}: "
                + $" {inputNumber == randomNumber || inputNumber >= randomNumber}");
            Console.WriteLine($"\t!(true): {!(true)}");

            /**************************************************************/
        }
    }
}
