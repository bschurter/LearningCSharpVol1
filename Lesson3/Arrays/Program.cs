string name1 = "Bob";
string name2 = "Jill";
string name3 = "Bill";

string[] names = { name1, name2, name3, "Susan" };

int[] nums = new int[5];
nums[0] = 1;
nums[4] = 111;
// nums[5] = 2;

Console.WriteLine(nums.Length);
Console.WriteLine(nums.GetUpperBound(0));

Console.WriteLine();

// Use < with Length 
for(int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

Console.WriteLine();

// Use <= with GetUpperBound 
for (int i = 0; i <= nums.GetUpperBound(0); i++)
{
    Console.WriteLine(nums[i]);
}


// Slicers
Console.WriteLine();

int[] primes1 = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] slice1 = primes1[2..6];
for (int i = 0; i <= slice1.GetUpperBound(0); i++)
{
    Console.WriteLine(slice1[i]);
}
slice1[0] = -5;

Console.WriteLine();

int[] slice2 = primes1[..6];
for (int i = 0; i <= slice2.GetUpperBound(0); i++)
{
    Console.WriteLine(slice2[i]);
}

Console.WriteLine();

int[] slice3 = primes1[4..];
for (int i = 0; i <= slice3.GetUpperBound(0); i++)
{
    Console.WriteLine(slice3[i]);
}

Console.WriteLine();

int[] slice4 = primes1[^4..];  // ^ == from the end
for (int i = 0; i <= slice4.GetUpperBound(0); i++)
{
    Console.WriteLine(slice4[i]);
}

// Spans

var span1 = primes1.AsSpan(2, 4);
span1[0] = -5;

ReadOnlySpan<int> span2 = primes1.AsSpan(2, 4);
//span2[0] = 5;   -- Illegal!

Console.WriteLine();