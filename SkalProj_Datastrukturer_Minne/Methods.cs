using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_structure
{
    public class Methods
    {
        public static string TrimListCapacity(List<string> items)
        {
            int previousCapacity = items.Capacity;
            items.TrimExcess();
            if (items.Capacity == previousCapacity)
            {
                return "Can't trim, memory is at 90%.";
            }
            else
            {
                return "Trimmed excess capacity.";
            }
        }

        public static string CapacityCountCheck(List<string> items)
        {
            return $"Count: {items.Count}, Capacity: {items.Capacity}";
        }

        // Method to extract command and value from the user input, adjusted for different types of input both 1- character and multiple characters.
        public static (string command, string value) ExtractCommandAndValue(string input)
        {
            string command;
            string value;

            if (input.StartsWith("push") || input.StartsWith("pop"))
            {
                command = input.Split(' ')[0].ToLower();
                value = input.Length > command.Length ? input.Substring(command.Length + 1).Trim() : string.Empty;
            }
            else if (input.StartsWith("+") || input.StartsWith("-"))
            {
                command = input.Length >= 1 ? input.Substring(0, 1) : string.Empty;
                value = input.Length > 1 ? input.Substring(1).Trim() : string.Empty;
            }
            else
            {
                command = input.Split(' ')[0].ToLower();
                value = input.Length > command.Length ? input.Substring(command.Length + 1).Trim() : string.Empty;
            }

            return (command, value);
        }

        // Method for reversing the string in menu 3.
        public static void ReverseText(string input = null)
        {

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Enter a string to reverse: ");
                input = Console.ReadLine();
            }
            
            Stack<char> charStack = new Stack<char>();

            foreach (char c in input)
            {
                charStack.Push(c);
            }

            StringBuilder reversedString = new StringBuilder();
            while (charStack.Count > 0)
            {
                reversedString.Append(charStack.Pop());
            }

            Console.WriteLine($"Reversed string: {reversedString}");
        }


    }

}

