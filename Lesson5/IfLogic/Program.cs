/*
               AND          OR          XOR       NOT
  a | b ||   a && b   |   a || b   |   a ^ b   |  !a
  ==+===++============+============+===========+========
  F | F || F && F = F | F || F = F | F ^ F = F | !F = T
  F | T || F && T = F | F || T = T | F ^ T = T | !F = T
  T | F || T && F = F | T || F = T | T ^ F = T | !T = F
  T | T || T && T = T | T || T = T | T ^ T = F | !T = F
*/

int x = 0;
int y = 0;

if (x > 0)
{
    Console.WriteLine("x is positive");
}
else if (x < 0)
{
    Console.WriteLine("x is negative");
}
else  // x is 0
{
    Console.WriteLine("x is 0");
}

if (y < 0)
{
    Console.WriteLine("y is negative");
}

//     a        b
if (x >= 0 && y < 0)
{
    Console.WriteLine("x is positive AND y is negative");
}

//     a        b
if (x >= 0 || y < 0)
{
    Console.WriteLine("x is positive OR y is negative");
}


/*
            ^ y-axis
            |
            |
   II       |     I
            |
            |origin  x-axis  
<-----------+------------>
            |
  III       |     IV
            |
            |
            v
*/

x = 0; y = 10;

if (x == 0 && y == 0)
{
    Console.WriteLine("origin");
}
else if (x == 0 ^ y == 0)
{
    if (x == 0)
    {
        Console.WriteLine("y-axis");
    }
    else
    {
        Console.WriteLine("x-axis");
    }
}
else if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("Quadrant I");
    }
    else
    {
        Console.WriteLine("Quadrant IV");
    }
}
else  // x < 0
{
    if (y > 0)
    {
        Console.WriteLine("Quadrant II");
    }
    else
    {
        Console.WriteLine("Quadrant III");
    }
}


string s1 = "";
if (s1 == null)
{
    Console.WriteLine("s1 is null");
}
else
{
    Console.WriteLine("s1 is not null");
}

if (string.IsNullOrEmpty(s1))
{
    Console.WriteLine("s1 is null or empty");
}
else
{
    Console.WriteLine("s1 is not null or empty");
}

int? z = null;
int v;
if (z == null)
{
    v = 0;
}
else
{
    v = z.Value;
}

v = z ?? 0;  // Null-coalescing operator: if z is null, assign 0 to v, otherwise assign the value of z to v

v = (z == null) ? 0 : z.Value;   // Ternary operator:   (conditional) ? <then> : <else>

string s2 = null;
int? length = s2?.Length;  // ?. - Null-conditional operator that either returns or calls the member if the object is not null, or returns null
int length2 = s2?.Length ?? 0;

string[] arr = new string[10];
int length3 = arr?[0].Length ?? 0;  // Safe array indexer syntax OR null-conditional operator for arrays
