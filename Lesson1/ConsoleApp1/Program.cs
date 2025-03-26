namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            //int y = 5;
            for (x = 0; x < 8; x++)
            {
                DoubleMe(x);
                Console.WriteLine(x);
            }
            Console.WriteLine("Hello, World!");
        }

        static void DoubleMe(int x)
        {
            Console.WriteLine(x * 2);
        }
    }
}
