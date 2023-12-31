﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure
{
    //Github test push for submit this version of file. V2.0
    public class Menus
    {

        // Nested menu for the main menu
        public static void ExtraExerciseMenu()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(0, 1, 2, 3, 4, 5, 6, 7) of your choice"
                    + "\n1. Find nth Odd number"
                    + "\n2. Find nth Even number"
                    + "\n3. Find nth Fibonacci number"
                    + "\n4. Recursive Odd number"
                    + "\n5. Recursive Even number"
                    + "\n6. Recursive Fibonacci number"
                    + "\n7. Go back to previous menu"
                    + "\n0. Exit the program");

                char inputExtra = ' ';                                   //Creates the character input to be used with the switch-case below.
                try
                {
                    inputExtra = Console.ReadLine()![0];                 //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException)                    //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();                                //Cleaning the console so it is clear and easy to read
                    Console.WriteLine("Please enter some input!\n");
                }
                switch (inputExtra)
                {
                    case '1':
                        ExtraExercise.HandleIterativeOdd();
                        break;

                    case '2':
                        ExtraExercise.HandleIterativeEven();
                        break;

                    case '3':
                        ExtraExercise.HandleIterativeFibonacci();
                        break;

                    case '4':
                        ExtraExercise.HandleRecursiveOdd();
                        break;

                    case '5':
                        ExtraExercise.HandleRecursiveEven();
                        break;

                    case '6':
                        ExtraExercise.HandleFibonacci();
                        break;

                    case '7':                        
                        return;

                    case '0':
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7) ");
                        break;
                }
            }
        }

    }
}
