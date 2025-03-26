using System.Text;

// Avoid exception with testing code
int x = 10;
int y = 0;
if (y != 0)
{
    int z = x / y;
}

// Multiple exception types and filtering by exception type
try
{
    y = 10;
    int z = x / y;

    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int a = Convert.ToInt32(input);

}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Divide error: {ex.Message}");
}
catch (Exception ex) when (ex is OverflowException || ex is FormatException)
{
    Console.WriteLine($"Format or overflow error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unknown error: {ex.Message}");
}

// Exception filtering
try
{
    x = -7;
    y = 0;
    int z = x / y;
}
catch (DivideByZeroException ex) when (x >= 0)
{
    Console.WriteLine($"Positive infinity: {ex.Message}");
}
catch (DivideByZeroException ex) when (x < 0)
{
    Console.WriteLine($"Negative infinity: {ex.Message}");
}

// Test ReadInt()
int b = ReadInt();
Console.WriteLine($"You entered: {b}");
try
{
    TestNumbers();
}
catch( Exception ex)
{
    Console.WriteLine($"TestNumbers() cased an error: {ex.Message}" );
}

// Method showing variable lifetimes when used with try
void TestNumbers()
{
    // x, y, and sb are available inside AND outside the try block, including try
    int x = 10;
    int y = 0;
    StringBuilder? sb = null;
    try
    {
        sb = new StringBuilder();
        y = 10;
        // z is only available within this try block, not in any of the catches
        int z = x / y;

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input);

        if (a < 0)
        {
            throw new InvalidDataException("a cannot be negative!");
        }
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Divide error: {ex.Message}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Format error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unknown error: {ex.Message}");
        throw;  // or throw ex;
    }
    finally
    {
        Console.WriteLine("This always executes!");
        try
        {
            sb?.Clear();
        }
        catch { /* Just swallow it */ }
    }
}

int ReadInt()
{
    int result = 0;
    do
    {
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            result = Convert.ToInt32(input);
            return result;
        }
        catch (FormatException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Format error: {ex.Message}");
            Console.ResetColor();
        }
        catch (OverflowException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Overflow error: {ex.Message}");
            Console.ResetColor();
        }
    } while (true);
}


