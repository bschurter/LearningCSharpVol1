int[] nums = { 1, 2, 3 };

int[,] twoD = { 
    { 1, 2, 3 },
    { 5, 9, 12 }, 
    { 0, 77, 2 },   // <== target the 1
    { 4, 3, 2 }
};

int val = twoD[2,1];  // row 2, column 1 (all 0-based)
Console.WriteLine(val);

twoD[2, 1] = 55;
val = twoD[2, 1];  // row 2, column 1 (all 0-based)
Console.WriteLine(val);

int[,] times = new int[10,10];
for (int i = 0; i < times.GetLength(0); i++)  // i represents row index
{
    for (int j = 0; j < times.GetLength(1); j++)
    {
        times[i, j] = i * j;
    }
}

for (int i = 0; i < times.GetLength(0); i++)  // i represents row index
{
    for (int j = 0; j < times.GetLength(1); j++)
    {
        int prod = times[i, j];
        Console.Write(prod + "\t");
    }
    Console.WriteLine();
}

int[,] sample = new int[31,10];

int[][] jagged = new int[31][];
jagged[0] = new int[3];
jagged[0][0] = 1;
jagged[0][1] = 5;
jagged[0][2] = 2;

jagged[1] = new int[2];
jagged[1][0] = 9;
jagged[1][1] = 3;

for(int i = 0; i < jagged.Length; i++ )
{
    if (jagged[i] != null)
    {
        for (int j = 0; j < jagged[i].Length; j++)
        {
            Console.Write(jagged[i][j] + "\t");
        }
        Console.WriteLine();
    }
}
