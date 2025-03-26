using System.Text;

namespace OverloadsAndParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = Power(5.1, 2);
            Console.WriteLine(num1);
            double num2 = Power(5);
            Console.WriteLine(num2);
            long num3 = Power(8, 2);
            Console.WriteLine(num3);

            Power(pow: 4, num: 5);
            TestNamedAndOptional(5, a: 7, d: 10);
            Math.Pow(y: 4, x: 3);

            var avg1 = Average(4, 5, 6, 7, 3);
            Console.WriteLine(avg1);
            //var avg2 = Average();
            //Console.WriteLine(avg2);

            Console.WriteLine(new string('-', 10) + " ByVal " + new string('-', 10));
            int x = 10;
            Console.WriteLine(x);
            TestByVal(x);
            Console.WriteLine(x);

            Console.WriteLine(new string('-', 10) + " ByRef " + new string('-', 10));
            x = 10;
            Console.WriteLine(x);
            TestByRef(ref x);
            Console.WriteLine(x);

            Console.WriteLine(new string('-', 10) + " RefByVal " + new string('-', 10));
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This is a test");
            Console.WriteLine(sb.ToString());
            TestRefByVal(sb);
            Console.WriteLine(sb.ToString());

            Console.WriteLine(new string('-', 10) + " RefByRef " + new string('-', 10));
            TestRefByRef(ref sb);
            Console.WriteLine();

            string s1 = "123";
            if (int.TryParse(s1, out int intVal))
            {

            }

            Console.WriteLine(new string('-', 10) + " TestOut " + new string('-', 10));
            TestOut(out int z);
            Console.WriteLine(z);

            Console.WriteLine(new string('-', 10) + " TestIn " + new string('-', 10));
            TestIn(z);

        }

        /// <summary>
        /// Passes a value type ByRef for optimal performance, but no changes allowed.
        /// </summary>
        /// <param name="z"></param>
        static void TestIn(in int z)
        {
            // z = 10;
            Console.WriteLine(z);
        }

        /// <summary>
        /// Using "in" with a reference type
        /// </summary>
        /// <param name="sb"></param>
        /// <remarks>While this is syntactically correct, it does not prevent changes to data stored in the heap!</remarks>
        static void TestIn(in StringBuilder sb)
        {
            sb.AppendLine();
        }

        static void TestOut(out int x)
        {
            x = 100;
        }

        static void TestByVal(int x)
        {
            x *= 2;
        }

        static void TestByRef(ref int x)
        {
            x *= 2;
        }

        static void TestRefByVal(StringBuilder s)
        {
            s.AppendLine("XXX");
            s = null;
        }

        static void TestRefByRef(ref StringBuilder s)
        {
            s = null;
        }


        #region Overloads
        /// <summary>
        /// Raises num to the power of pow
        /// </summary>
        /// <param name="num">Base value</param>
        /// <param name="pow">Power</param>
        /// <returns>num ^ pow</returns>
        static double Power(double num, double pow = 2.0)
        {
            return Math.Pow(num, pow);
        }

        /// <summary>
        /// Raises num to the power of pow
        /// </summary>
        /// <param name="num">Base value</param>
        /// <param name="pow">Power</param>
        /// <returns>num ^ pow</returns>
        static long Power(int num, int pow)
        {
            return (long)Math.Pow(num, pow);
        }
        #endregion Overloads

        #region Optional and Named Parameters

        static void TestNamedAndOptional(int x, int a = 0, int b = 0, int c = 0, int d = 0)
        {

        }
        #endregion Optional and Named Parameters

        #region parameter arrays
        static double Average(params double[] values)
        {
            if (values != null && values.Length > 0)
            {
                double sum = 0;
                foreach (double d in values)
                {
                    sum += d;
                }
                return sum / values.Length;
            }
            return 0;
        }
        #endregion parameter arrays
    }
}
