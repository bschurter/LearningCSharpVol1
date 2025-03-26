// What enums replace...
//const int Red = 1;
//const int Green = 2;
//const int Blue = 3;

//void SetColor(int color)
//{
//    if (color == Red)
//    {
//        // Red
//    }
//    if (color == Green)
//    {
//        // Green
//    }
//    if (color == Blue)
//    {
//        // Blue
//    }
//}

SetColor(Colors.Green);
Colors c1 = Colors.Transparent;
Colors? c2 = null;

FontStyles fs1 = FontStyles.Normal;
FontStyles fs2 = FontStyles.Bold | FontStyles.Italic;
FontStyles fs3 = (FontStyles)15;  // All bits set
if (fs2.HasFlag(FontStyles.Italic))
{
    Console.WriteLine("Italic");
}
if (fs2.HasFlag(FontStyles.Bold | FontStyles.Italic))
{
    Console.WriteLine("Bold & Italic");
}
if (fs2.HasFlag(FontStyles.Bold | FontStyles.Underline))
{
    Console.WriteLine("Bold & Underline");
}
if (fs3.HasFlag(FontStyles.Bold | FontStyles.Italic))
{
    Console.WriteLine("Bold & Italic");
}

fs2 &= ~FontStyles.Italic;  // "Turn off" italic
Console.WriteLine(fs2);

//Console.WriteLine(fs1);
//Console.WriteLine(fs2);
//Console.WriteLine(fs3);

// 8 4 2 1
// S U I B
//==========
// 0 0 0 0 = Normal
// 0 0 0 1 = Bold
// 0 0 1 0 = Italic
// 0 1 0 0 = Underline
// 1 0 0 0 = StrikeThrough

// 0 0 1 1 = Bold | Italic
// 0 0 0 1 = Bold
// OR Together ===============================
// 0 0 1 1 = Bold | Italic

// 0 0 1 1 = Bold | Italic
// 1 1 0 1 = ~Italic
// AND Together ===============================
// 0 0 0 1 = Bold



void SetColor(Colors color)
{
    if (color == Colors.Red)
    {
        // Red
    }
    if (color == Colors.Green)
    {
        // Green
    }
    if (color == Colors.Blue)
    {
        // Blue
    }
}

enum Colors
{
    Transparent,
    Red = 1,
    Green,  // 2 by default
    Blue = 3
}

[Flags]
enum FontStyles
{
    Normal = 0,
    Bold = 1,
    Italic = 2,
    Underline = 4,
    StrikeThrough = 8
}