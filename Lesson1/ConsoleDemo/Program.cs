namespace ConsoleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            if (args != null && args.Length > 0)
            {
                name = args[0];
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter your name: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                name = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello, " + name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Goodbye");
            Console.ResetColor();
            Console.ReadLine();
            //Console.SetCursorPosition(0, 0);
            //Console.WriteLine("****");
        }
    }
}
