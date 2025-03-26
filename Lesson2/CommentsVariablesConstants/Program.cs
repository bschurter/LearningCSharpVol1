namespace CommentsVariablesConstants
{
    /// <summary>
    /// The Program class itself
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example constant
            const double pi = 3.141592653589;
            double radius = 10.5;
            double area = pi * radius * radius;
            
            /* =====================================================
             A simple survey of C# data types
            ===================================================== */
            int x = 2_147_483_000;
            x = 1234;
            Console.WriteLine(x);

            // int uses 4 bytes of memory
            int y = 0;
            int z = default;
            int min = int.MinValue;
            int max = int.MaxValue;

            // long uses 8 bytes of memory
            long l = 1_234_567_890_123_456L;

            // Small ints
            short sh = 32_000;
            byte b = 255;  // unsigned

            // Unsigned and signed values
            uint ui = 2_147_483_999U;
            ulong ul = ulong.MaxValue;
            sbyte sb = -2;  // Signed bytes allow negative values down to -128

            // Floating point types
            float f = 1.0f;
            double d = 1.0;  // 8 bytes
            decimal m = 1.3333333333m;

            // Dates and times
            DateTime now = DateTime.Now;
            DateTime dt1 = new DateTime(2025, 2, 13);
            DateTime dt2 = new DateTime(2025, 2, 13, 14, 15, 16);
            DateTime dt3 = DateTime.Parse("2025-02-13 2:15:16PM");

            // Strings
            string s = "ABC";

            double d2 = DoubleMe(4.0);
        }

        /// <summary>
        /// Doubles the number passed in
        /// </summary>
        /// <param name="x">The value to double</param>
        /// <returns>The doubled value</returns>
        static double DoubleMe(double x)
        {
            return x * 2;
        }
    }
}
