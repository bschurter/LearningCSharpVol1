using System.Runtime.CompilerServices;

int x = 5;

// Case statement
switch(x)
{
    case 0:
        Console.WriteLine("x is 0");
        break;
    case 1:
        Console.WriteLine("x is 1");
        break;
    case 2:
    case 3:
        Console.WriteLine("x is 3 or 4");
        break;
    default:
        Console.WriteLine("Don't know");
        break;
}

// Case statement with enums
Days day1 = Days.Saturday;
switch(day1)
{
    case Days.Saturday:
    case Days.Sunday:
        Console.WriteLine("Weekend");
        break;
    case Days.Monday:
        Console.WriteLine("Start of the work week");
        break;
    case Days.Friday:
        Console.WriteLine("End of the work week");
        break;
    default:
        Console.WriteLine("Weekday");
        break;
}

// Case pattern matching
switch (x)
{
    case 0:
        Console.WriteLine("x is 0");
        break;
    case > 0:
        Console.WriteLine("x is positive");
        break;
    case < 0:
        Console.WriteLine("x is negative");
        break;
}


// Case pattern matching
char ch = 'o';
switch (ch)
{
    case 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U':
        Console.WriteLine("Vowel");
        break;
    case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z'):
        Console.WriteLine("Consonant");
        break;
    default:
        Console.WriteLine("Not a letter");
        break;
}

Console.WriteLine();

// Emulated fall-through
Burgers burger = Burgers.Cheeseburger;
switch(burger)
{
    case Burgers.Plain:
        Console.WriteLine("Bun");
        Console.WriteLine("Patty");
        break;
    case Burgers.Cheeseburger:
        Console.WriteLine("Cheese");
        goto case Burgers.Plain;
    case Burgers.UltimateCheeseburger:
        Console.WriteLine("Lettuce");
        Console.WriteLine("Tomato");
        goto case Burgers.Cheeseburger;
}

Console.WriteLine();

// Switch expression
int planet = 5;
string planetType = planet switch
{
    >= 1 and <= 4 => "rocky",
    5 or 6 => "gas giant",
    > 6 and <= 8 => "ice giant",
    _ => "unknown"
};
Console.WriteLine($"Planet {planet} is a {planetType} planet");

// Tuple pattern matching
var pt = (x: 0, y: 4);
string location = pt switch
{
    (0, 0) => "origin",
    ( > 0, > 0) => "Quadrant I",
    ( < 0, > 0) => "Quadrant II",
    ( < 0, < 0) => "Quadrant III",
    ( > 0, < 0) => "Quadrant IV",
    (_, 0) => "x-axis",
    (0, _) => "y-axis",
    //_ => "unknown"
};
Console.WriteLine(  );
Console.WriteLine(location);

// Positional pattern matching
DateTime dt = new DateTime(2025, 2, 10);
string season = dt switch
{
    (_, >= 1 and <=3, _) => "winter",
    (_, >= 4 and <= 6, _) => "spring",
    (_, >= 7 and <= 9, _) => "summer",
    (_, >= 10 and <= 12, _) => "fall",
    _ => "unknown"
};
Console.WriteLine();
Console.WriteLine($"The date {dt:yyyy-MM-dd} is in {season}");

// Property pattern matching
season = dt switch
{
    { Month: >= 1 and <=3, Year: > 2000 } => "winter",
    { Month: >= 4 and <= 6, Year: > 2000 } => "spring",
    { Month: >= 7 and <= 9 } => "summer",
    { Month: >= 10 and <= 12 } => "fall",
    _ => "unknown"
};
Console.WriteLine();
Console.WriteLine($"The date {dt:yyyy-MM-dd} is in {season}");

// Type pattern matching
object test = 10;
string result = test switch
{
    int i when i > 0 => $"positive int: {i}",
    int i when i < 0 => $"negative int: {i}",
    int i when i == 0 => "zero int",
    double d => "double",
    string s => s,
    null => "null",
    _ => "???"
};

Console.WriteLine(result);




enum Burgers { Plain, Cheeseburger, UltimateCheeseburger };

enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };