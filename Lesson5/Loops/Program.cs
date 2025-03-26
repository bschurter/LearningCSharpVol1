
//============================================
// for loop
//============================================

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i <= 100; i += 10)
    Console.WriteLine(i);

List<int> fib = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21 };

for (int i = 0; i < fib.Count; i++)
{
    Console.WriteLine(fib[i]);
}

for (int i = fib.Count - 1; i >= 0; i--)
{
    // Remove items from list backwards so you don't break the loop
    Console.WriteLine(fib[i]);
    if (fib[i] % 2 == 0)
    {
        fib.RemoveAt(i);
    }
}

Console.WriteLine();

//============================================
// Nested for loops
//============================================

int[,] times = new int[12, 10];
for (int row = 0; row <= times.GetUpperBound(0); row++)
{
    for (int col = 0; col <= times.GetUpperBound(1); col++)
    {
        times[row, col] = row * col;
    }
}

for (int row = 0; row <= times.GetUpperBound(0); row++)
{
    for (int col = 0; col <= times.GetUpperBound(1); col++)
    {
        Console.Write($"{times[row, col],3} ");
    }
    Console.WriteLine();
}

//============================================
// foreach loop
//============================================
foreach (int value in fib)
{
    if (value >= 8)
    {
        break;
    }
    Console.WriteLine(value);
}

foreach (int value in fib)
{
    // Only print the odd numbers
    if (value % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(value);
}

//============================================
// while loop
//============================================
int val1 = 1;
int val2 = 1;
int fibval = 0;
Console.Write($"{val1} {val2} ");
while (fibval < 100)
{
    fibval = val1 + val2;
    Console.Write($"{fibval} ");
    val1 = val2;
    val2 = fibval;
}

//============================================
// do, or do-while loop
//============================================
val1 = 1;
val2 = 1;
fibval = 100;
Console.Write($"{val1} {val2} ");
do
{
    fibval = val1 + val2;
    Console.Write($"{fibval} ");
    val1 = val2;
    val2 = fibval;
} while (fibval < 100);

bool quit = false;

//============================================
// Loop guarded by a sentinel
//============================================
int x = 10;
while (!quit)
{
    x++;
    if (x > 100000)
    {
        quit = true;
    }
}

//============================================
// Infinite loop constructs
// Ctrl-C to break if you uncomment
//============================================

//for (; ;)
//{
//    // Infinite loop
//}

//while (true)
//{
//    // Infinite loop
//}

//do
//{
//    // Infinite loop
//} while (true);