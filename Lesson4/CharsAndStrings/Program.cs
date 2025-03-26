// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, " + "Bruce");

string s1 = "A";
char c1 = 'A';  // 65 or 0x41  Dec: 0123456789  Hex: 0123456789ABCDEF
char c2 = (char)65;
char c3 = (char)0x41;
Console.WriteLine(c1 + c2 + c3);   // Shows the numeric result, not "AAA"

int x = 10 + c1;
Console.WriteLine(x);

char copy = '©';
char copy2 = (char)0xA9;
char copy3 = '\u00A9';
char copy4 = '\xA9';
Console.WriteLine(copy);

char back = '\\';
char cr = '\r';   // Carriage return
char nl = '\n';   // line feed

string crlf = Environment.NewLine;

Console.Write("ABC" + nl + "DEF");

char tab = '\t';
char apos = '\'';

var key = Console.ReadKey();
Console.WriteLine(key.KeyChar);

string path = "C:\\test.txt";  // Double up the back slashes
string literalpath = @"C:\test.txt";  // no escapes
string withquote = "Bill said, \"Hi\"!";

string s2 = "AAAAA";
string s3 = new string('=', 40);  // Create a string with repeating chars
Console.WriteLine(s3);