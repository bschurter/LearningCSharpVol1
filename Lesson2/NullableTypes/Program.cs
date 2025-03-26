string s = null; // Legal, but should be string? if we are assigning null
string t = s!;
string u = t;

//int x = null;   <== Illegal!
Nullable<int> x = new Nullable<int>();  // Legal, but verbose
x = null;
if (x.HasValue)
{
    Console.WriteLine("x is not null");
}
else
{
    Console.WriteLine("x is null");
}

int? y = null;  // Much better!
if (y == null)
{
    Console.WriteLine("y is null");
}

string? s2 = null;
Console.ReadLine();