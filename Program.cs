﻿/*
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

        }
    }
}