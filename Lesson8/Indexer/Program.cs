namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int num = numbers[1];
            //numbers[1] = -1;

            MyString s1 = new MyString("ABCdef");
            Console.WriteLine(s1);
            s1[3] = 'D';
            s1[4] = 'E';
            s1[5] = 'F';
            s1[6] = 'G'; // Should be ignored
            Console.WriteLine(s1);
            Console.WriteLine(s1[2]);
            Console.WriteLine(s1[99]);  // Should return null
            Console.WriteLine(s1[3]);

            Console.WriteLine(new string('=', 30));
            var fib = new Fibonacci();
            Console.WriteLine(fib[5]);
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(fib[i]);
            }

        }
    }

    class Fibonacci
    {   
        // index: 0  1  2  3  4  5  6   7
        // fib:   1, 1, 2, 3, 5, 8, 13, 21, ..
        public int this[int index]
        {
            get
            {
                if (index <= 1)
                {
                    return 1;
                }
                int n1 = 1;
                int n2 = 1;
                int fib = 0;
                for (int i = 2; i <= index; i++)
                {
                    fib = n1 + n2;
                    n1 = n2;
                    n2 = fib;
                    if (index == i)
                    {
                        break;
                    }
                }
                return fib;  
            }
        }
    }


    class MyString
    {
        private char[] _chars = [];

        public MyString(string s)
        {
            _chars = s.ToCharArray();
        }

        public override string ToString()
        {
            return new string(_chars);
        }

        public int Length => _chars.Length;

        public char this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    return (char)0;
                }
                return _chars[index];
            }
            set
            {
                if (index >= 0 && index < Length)
                {
                    _chars[index] = value;
                }
            }
        }
    }
}
