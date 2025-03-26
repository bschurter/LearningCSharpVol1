int x = 10;
long l = x;
int y = (int)l;

double d = 123.25;
// Casting truncates
int j = (int)d;

int k = (int)Math.Round(d);

// Convert rounds
int i = System.Convert.ToInt32(d);


string s1 = "123.45A";
// This will throw an exception:
// double d1 = double.Parse(s1);  
if (double.TryParse(s1, out double d1))
{
    Console.WriteLine(d1);
}
else
{
    Console.WriteLine(s1 + " is a bad double");
}
Console.WriteLine(d1);

string s2 = "123.45";
if (int.TryParse(s2, out int i2))
{ 
    Console.WriteLine(i2);
}
else
{
    Console.WriteLine(s2 + " is a bad int");
}

if (DateTime.TryParse("2025-02-15", out DateTime dt))
{
    Console.WriteLine(dt);
}

Console.Write("Enter your date of birth: ");
string dobString = Console.ReadLine();
if (DateTime.TryParse(dobString, out DateTime dob))
{
    Console.WriteLine("Your birthday is " + dob);
    Console.WriteLine("Which is on " + dob.DayOfWeek);
}
else
{
    Console.WriteLine(dobString + " is not a date");
}

Console.WriteLine();