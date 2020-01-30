﻿using System;

namespace PROGRAM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement: ");
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                /* 
                   This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                   Depending on the value of the user input between 1 and 20, a different type of 
                   iterative statement will execute. 
                */
                // If the value of user input is between 1 and 5, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 100)) 
                {
                    // Use loopnum  the while loop while keeping number intact
                    int loopNum = value_of_input;

                    // While loop that will loop through what the user has input. While loop will loop untill loopNum reaches 0
                    while (loopNum > 0)
                    {
                        // writeline to display output
                        Console.WriteLine("You have entered: " + value_of_input + " This is the current integer value in the loop: " + loopNum);
                        // decrease loopNet down by one to prevent infinite loop
                        loopNum--;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
            } // End of Main
    } // End of class
}
