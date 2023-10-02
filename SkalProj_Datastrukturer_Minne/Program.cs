using System;
using System.Xml.XPath;
using static Data_structure.Methods;
using static Data_structure.ExtraExercise;

namespace Data_structure
{
    class Program
    {
        //Github test push for submit this version of file. V1.2
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. Check Parenthesis"
                    + "\n5. Extra Functionality Menu"
                    + "\n0. Exit the application");
                char input = ' ';                                   //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0];                 //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException)                    //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();                                //Cleaning the console so it is clear and easy to read
                    Console.WriteLine("Please enter some input!\n");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParenthesis();
                        break;
                    case '5':
                        Menus.ExtraExerciseMenu();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>

        #region Task 1
        static void ExamineList()
        {
            List<string> items = new List<string>();
            Console.WriteLine("Use '+' to add an item or '-' to remove an item. Type 'exit' to return to the main menu.");

            while (true)
            {
                Console.Write("What would you like to do next? ");
                string input = Console.ReadLine()!;

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                var (command, value) = ExtractCommandAndValue(input); // Use the method to extract command and value


                switch (command)
                {
                    case "+":
                        items.Add(value);
                        Console.WriteLine($"Added: {value}");
                        Console.WriteLine(CapacityCountCheck(items));
                        break;

                    case "-":
                        items.Remove(value);
                        Console.WriteLine($"Removed: {value}");
                        Console.WriteLine(CapacityCountCheck(items));
                        break;

                    case "trim": //Extra feature to trim excess capacity
                        Console.WriteLine(TrimListCapacity(items));
                        Console.WriteLine(CapacityCountCheck(items));
                        break;

                    case "exit":
                        return; //Exits the method and returns to the main menu

                    default:
                        Console.WriteLine("Please use only '+' or '-' to add or remove items. Eventually use 'trim' or 'exit'.");
                        break;
                }

                //1.Complete the implementation of the ExamineList method so that the examination can be carried out.
                //Implementation done

                //2.When does the list's capacity increase? (That is, the size of the underlying array)
                //When the count exceeds the capacity

                //3.By how much does the capacity increase?
                //The capacity increases by 4 when the count exceeds the capacity (default capacity is 4) and then doubles when the count exceeds the capacity again (8, 16, 32, etc.) 

                //4.Why doesn't the list's capacity increase at the same rate as elements are added? 
                //The List<T> in C# increases its capacity by doubling, not one-by-one, to optimize performance.
                //This reduces the frequency of expensive array resizing operations, providing a balance between memory usage and speed.

                //5.Does the capacity decrease when elements are removed from the list?
                //No, the List<T> does not automatically decrease its capacity when elements are removed.
                //The capacity remains the same until explicitly resized using methods like TrimExcess(). (commented out in the code above)

                //6.When is it advantageous to use a custom-defined array instead of a list?
                //When you know the exact number of elements you want to store in the array and you don't want to add or remove elements from it. 
                //The array is also faster than the list when it comes to accessing elements.
                //The list is better when you want to add or remove elements from it, since it automatically resizes itself and you don't have to worry about the capacity.
                //Custom-defined arrays are especially better when interacting with APIs that require arrays as input.

                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch statement with cases '+' and '-'
                 * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
                 * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
                 * In both cases, look at the count and capacity of the list
                 * As a default case, tell them to use only + or -
                 * Below you can see some inspirational code to begin working.
                */

                //List<string> theList = new List<string>();
                //string input = Console.ReadLine();
                //char nav = input[0];
                //string value = input.substring(1);

                //switch(nav){...}
            }
        }
            #endregion
            /// <summary>
            /// Examines the datastructure Queue
            /// </summary>

        
#region Task 2
        //First in First out principle; FIFO
        static void ExamineQueue()
        {

                Queue<string> items = new Queue<string>();
                Console.WriteLine("Use 'enq' to enqueue an item or 'deq' to dequeue an item. Type 'exit' to return to the main menu.");

                while (true)
                {
                Console.Write("What would you like to do next? ");
                string input = Console.ReadLine()!;

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                var (command, value) = ExtractCommandAndValue(input); // Use the method to extract command and value

                switch (command)
                {
                    case "exit":
                        return;

                    case "enq":
                        if(string.IsNullOrEmpty(value))
                        {
                            Console.WriteLine("Please enter a value to enqueue.");
                            continue;
                        }
                        items.Enqueue(value);
                        Console.WriteLine($"Enqueued: {value}");
                        break;

                    case "deq":
                        if (items.Count > 0)
                        {
                            string dequeuedItem = items.Dequeue();
                            Console.WriteLine($"Dequeued: {dequeuedItem}");
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty.");
                        }
                        break;

                    default:
                        Console.WriteLine("Please use 'enq' to enqueue or 'deq' to dequeue items.");
                        continue;
                }

                Console.WriteLine($"Queue Count: {items.Count}");
            

        }

                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch with cases to enqueue items or dequeue items
                 * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
                */
        }
        #endregion
        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
#region Task 3
        //First in Last out principle; FILO
        static void ExamineStack()
        {
                Stack<string> items = new Stack<string>();
                Console.WriteLine("Use 'push' to push an item or 'pop' to pop an item.");
                Console.WriteLine("Please use 'reverse' to reverse a string or 'exit' to exit.");

            while (true)
                {
                Console.Write("What would you like to do next? ");
                string input = Console.ReadLine()!;

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                var (command, value) = ExtractCommandAndValue(input); // Use the method to extract command and value

                switch (command)
                {
                    case "exit":
                        return;

                    case "push":
                        if (string.IsNullOrWhiteSpace(value))
                        {
                            Console.WriteLine("Please provide a valid item to push.");
                            continue;
                        }
                        items.Push(value);
                        Console.WriteLine($"Pushed: {value}");
                        break;

                    case "pop":
                        if (items.Count > 0)
                        {
                            string poppedItem = items.Pop();
                            Console.WriteLine($"Popped: {poppedItem}");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty.");
                        }
                        break;

                    case "reverse":
                        ReverseText(value);
                        break;

                    default:
                        Console.WriteLine("Please use 'push' to push or 'pop' to pop items.");
                        Console.WriteLine("Please use 'reverse' to reverse a string or 'exit' to exit.");
                        continue;
                }

                    Console.WriteLine($"Stack Count: {items.Count}");
                }
            
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }
        #endregion
#region Task 4
        //Method to check for balanced parentheses
        //The method uses a stack to check for balanced parentheses
        //The method uses a helper method to check for matching pairs of parentheses
        //The method handles other characters than parentheses as well but ignores them when checking for balanced parentheses
        //The method does handle nested parentheses as well
        static void CheckParenthesis()
        {
            Console.WriteLine("Use 'check' followed by a string to check for balanced parentheses. Type 'exit' to return to the main menu.");

            while (true)
            {
                Console.Write("What would you like to do next? ");
                string input = Console.ReadLine()!;

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                var (command, value) = ExtractCommandAndValue(input);   // Use the method to extract command and value

                switch (command)
                {
                    case "exit":
                        return;

                    case "check":
                        if (string.IsNullOrWhiteSpace(value))
                        {
                            Console.WriteLine("Please provide a valid string to check.");
                            continue;
                        }

                        Stack<char> stack = new Stack<char>();
                        bool isBalanced = true;

                        foreach (char ch in value)
                        {
                            if (ch == '(' || ch == '{' || ch == '[')
                            {
                                stack.Push(ch);
                            }
                            else if (ch == ')' || ch == '}' || ch == ']')
                            {
                                if (stack.Count == 0)
                                {
                                    isBalanced = false;
                                    break;
                                }

                                char openParanthesis = stack.Pop();
                                if (!IsMatchingPair(openParanthesis, ch))
                                {
                                    isBalanced = false;
                                    break;
                                }
                            }
                        }

                        if (isBalanced && stack.Count == 0)
                            Console.WriteLine("The string has balanced parentheses.");
                        else
                            Console.WriteLine("The string does not have balanced parentheses.");
                        break;

                    default:
                        Console.WriteLine("Please use 'check' followed by a string to check for balanced parentheses.");
                        break;
                }
            }
        }
        //Helper method to check for matching pairs of parentheses
        //Returns true if the parentheses are matching pairs, false otherwise
        //The method handles other characters than parentheses as well but ignores them when checking for matching pairs of parentheses
        static bool IsMatchingPair(char char1, char char2)
        {
            return (char1 == '(' && char2 == ')') || (char1 == '{' && char2 == '}') || (char1 == '[' && char2 == ']');
        }
        #endregion
    }
}

