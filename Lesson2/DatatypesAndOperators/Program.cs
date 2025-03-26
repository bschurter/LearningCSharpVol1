IntegerStuff();
FloatingPointStuff();
BoolStuff();
DateStuff();

static void IntegerStuff()
{
    // int stuff
    int score = 242;
    int maxScore = 250;
    int pct = score * 100 / maxScore;
    Console.WriteLine(pct);

    // Divide and modulus
    int dividend = 17;
    int divisor = 4;
    int quotient = dividend / divisor;
    Console.WriteLine(quotient);
    int mod = dividend % divisor;
    Console.WriteLine(mod);

    //for (int i = 0; i < 1000; i++)
    //{
    //    if (i % 100 == 0)
    //    {
    //        Console.WriteLine(i);
    //    }
    //}

    int x = 10;
    x = x + 1;
    x += 1;
    x++;
    ++x;
    // x == 14
    int y = x++;
    // y = 14, x = 15
    Console.WriteLine("x: " + x + ", y: " + y);
    y = ++x;
    Console.WriteLine("x: " + x + ", y: " + y);

    int n = -10;
    int p = +10;

    // 1
    // 2 6 3 1
    // 8 4 2 6 8 4 2 1
    // ----------------
    // 0 0 0 0 0 0 0 0 = 0
    // 
    // 0 0 0 0 1 1 0 1 = 13
    // 0 0 0 1 1 0 1 0 = 26 << 1
    // 0 0 1 1 0 1 0 0 = 52 << 1

    // 0 0 0 0 1 1 0 1 = 13
    // 0 0 0 0 0 1 1 0 = 6

    int b = 13;
    Console.WriteLine(b << 2); // Multiply by 2^2 (4)
    Console.WriteLine(b >> 2); // Divide by 2^2 (4)

    Console.WriteLine(b << 4); // Multiply by 2^4 (16)
}

static void FloatingPointStuff()
{
    float f = 1.234567890f;
    Console.WriteLine(f);
    double d = 1.2345678901234567890;
    Console.WriteLine(d);

    double d1 = 0.3;
    double d2 = 0.1 + 0.2;
    Console.WriteLine(d1 == d2);

    double epsilon = 1e-10; // 0.0000000001
    bool equal = Math.Abs(d1 - d2) < epsilon;
    Console.WriteLine(equal);

    decimal dec1 = 0.3m;
    decimal dec2 = 0.1m + 0.2m;
    Console.WriteLine(dec1 == dec2);

}

static void BoolStuff()
{
    bool a = false;
    bool b = true;

    int x = 1;
    int y = 2;

    Console.WriteLine(x == y);
    Console.WriteLine(x != y);
    Console.WriteLine(x < y);
    Console.WriteLine(x > y);
    Console.WriteLine(x <= y);
    Console.WriteLine(x >= y);

    /* Truth Table:
                 AND         OR        XOR     NOT
      a | b ||  a && b  |  a || b  |  a ^ b  | !a
     ===+===++==========+=========================
      F | F ||    F     |    F     |    F    | T
      F | T ||    F     |    T     |    T    | T
      T | F ||    F     |    T     |    T    | F
      T | T ||    T     |    T     |    F    | F
    */

    Console.WriteLine(a && b);
    Console.WriteLine(a || b);
    Console.WriteLine(a ^ b);
    Console.WriteLine(!a);

}

static void DateStuff()
{
    DateTime now = DateTime.Now;
    DateTime utc = DateTime.UtcNow;

    DateTime dt = new DateTime(2025, 02, 14, 18, 37, 15, 25);
    DateTime dt2 = new DateTime(2025, 01, 31, 23, 59, 59);

    var diff = dt.Subtract(dt2);
    Console.WriteLine(diff.TotalDays);
    var diff2 = dt2.Subtract(dt);
    Console.WriteLine(Math.Abs(diff2.TotalDays));

    var nextMonth = dt2.AddMonths(1);
    Console.WriteLine(dt2);
    Console.WriteLine(nextMonth);

    var newDate = dt.AddMonths(2).AddDays(6).AddHours(7);
    Console.WriteLine(dt);
    Console.WriteLine(newDate);

    TimeSpan ts1 = new TimeSpan(1, 1, 1, 1);
    TimeSpan ts2 = new TimeSpan(10, 3, 4, 5);

    TimeSpan ts3 = ts1 + ts2;
    Console.WriteLine(ts3);

}