using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class ConsoleHelpers
    {
        public static ConsoleColor PromptColor { get; set; }
        public static ConsoleColor InputColor { get; set; }
        public static ConsoleColor ErrorColor { get; set; }

        static ConsoleHelpers()
        {
            PromptColor = ConsoleColor.White;
            InputColor = ConsoleColor.Yellow;
            ErrorColor = ConsoleColor.Red;
        }

        public static void WriteBorder(char ch = '=', int length = 0)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = PromptColor;
                int row = Console.CursorTop;
                Console.SetCursorPosition(0, row);
                if (length == 0)
                {
                    length = Console.WindowWidth;
                }
                Console.WriteLine(new string(ch, length));
                Console.SetCursorPosition(0, row + 1);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ErrorColor;
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.ForegroundColor = originalColor;
            }
        }

        public static bool ReadBool(string prompt = "Please enter a Boolean value: ")
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = PromptColor;
                Console.Write(prompt);
                Console.ForegroundColor = InputColor;
                string input = (Console.ReadLine() ?? string.Empty).ToLower().Trim();
                if (input == "y" || input == "yes" || input == "true" || input == "1")
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ErrorColor;
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.ForegroundColor = originalColor;
            }
            return false;
        }

        public static string ReadString(string prompt = "Please enter a string: ", int minLength = 0, int maxLength = 0)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            try
            {
                bool done = false;
                while (!done)
                {
                    done = true;
                    Console.ForegroundColor = PromptColor;
                    Console.Write(prompt);
                    Console.ForegroundColor = InputColor;
                    string input = Console.ReadLine() ?? string.Empty;
                    if ((maxLength > 0) && (input.Length > maxLength))
                    {
                        input = input.Substring(0, maxLength);
                    }
                    if (input.Length < minLength)
                    {
                        Console.ForegroundColor = ErrorColor;
                        Console.WriteLine($"The text entered must be at least {minLength} characters in length.  Please try again.");
                        done = false;
                    }
                    if (done)
                    {
                        return input;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ErrorColor;
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.ForegroundColor = originalColor;
            }
            return string.Empty;
        }

    }
}
