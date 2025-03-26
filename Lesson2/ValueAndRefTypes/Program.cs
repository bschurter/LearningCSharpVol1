namespace ValueAndRefTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            ValueAndRefTypes();
            RefTypes();
        }

        static void ValueTypes()
        {
            int x;
            x = 10;
            int y = 20;
            y++;
            int z = x;
        }

        static void ValueAndRefTypes()
        {
            int x = 10;
            string s = "ABC";
            Console.WriteLine(s);
            s = s + "D";
        }

        static void RefTypes()
        {
            var p1 = new Point() { X = 5.1f, Y = 7.2f };
            var p2 = new Point() { X = 1.2f, Y = 2.9f };
            Point p3 = p1;
            p3.X = 4.6f;
            p1 = null;

            // object can hold any variable type
            object obj = p3;

            // This is boxing and should be avoided
            object o2 = 10;
            // This is unboxing, taking the reference data and putting back in the stack
            int x = (int)o2;
        }

        class Point
        {
            public float X { get; set; }
            public float Y { get; set; }
        }
    }
}
