
using StaticClasses;
using static StaticClasses.ConsoleHelpers;

//Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hello World!");

ErrorColor = ConsoleColor.Cyan;
WriteBorder();

if (ReadBool("Do you want to quit? "))
{
    return;
}

//Console.WriteLine("Hello World 2!");

string name = ReadString("Please tell me your name: ", 2, 10);
Console.WriteLine($"Nice to meet you, {name}");

Globals.BasePath = Path.GetTempPath();
