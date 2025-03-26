//ListFolders("c:\\CSharp");
int x = 5;
Console.WriteLine($"{x}! = {Factorial(x)}");
Console.WriteLine($"{x}! = {FactorialTail(x)}");

int exp = 4;
Console.WriteLine($"{x}^{exp} = {Power(x, exp)}");

int Power(int baseNum, int exp)
{
    if (exp == 0) return 1;
    return baseNum * Power(baseNum, exp - 1);
}

int Factorial(int n)
{
    if (n <= 1) return n;
    return n * Factorial(n - 1);
}

int FactorialTail(int n, int total = 1)
{
    if (n <= 1) return total;
    return FactorialTail(n - 1, n * total);
}

void ListFolders(string path, int depth = 0)
{
    // C:\csharp\lesson1\lab1\project1
    // csharp
    //   lesson1
    //     lab1
    //       project1
    Console.WriteLine(new string(' ', depth * 2) +  Path.GetFileName(path));
    var dirs = Directory.GetDirectories(path);
    foreach (var dir in dirs)
    {
        ListFolders(dir, depth + 1);
    }
}