// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine();

int x = 10;  // 10 is a literal expression, the whole line is a declaration statement
int y = x * 2; // x * 2 is an arithmetic expression, expression statement AND a declaration statement
bool isPositive = x > 0;  // x > 0 boolean expression
int abs = Math.Abs(y);  // Math.Abs(y) is a method expression

// Lambda expression
var expr = (int a, int b) => a + b;
int z = expr(x, y);

// Object instantiation
DateTime dt = new DateTime(2025, 2, 14);

if (isPositive)  // Selection statement
{
    Console.WriteLine("Positive");
}

// Multi-expression statement
int w = (x * 10) + (y / 5);

// Iteration statement
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i > 5) break;  // Jump statement: break
}

// Exception handling statement
int d = default;
try
{
    d = 5 / x;
}
catch (Exception ex)
{
    Console.WriteLine(d);
    Console.WriteLine(ex.Message);
}

double DoubleMe(double dbl)
{
    return dbl * 2;
}

{
    // Just a random block in the code
    int v = 10;
}
// v++; -- illegal!!!