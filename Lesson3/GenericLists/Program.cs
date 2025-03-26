int[] arr = new int[] { 1, 2, 3};

List<int> list = new List<int>() { 1, 2, 3 };
// 1, 2, 3
list.Add(4);  // Adds 4 to the end
// 1, 2, 3, 4
list.Insert(0, -1);  // Adds -1 to the beginning of the list (before index 0)
// -1, 1, 2, 3, 4
list.RemoveAt(2);  // Removes the value at index 2
// -1, 1, 3, 4

foreach (var i in list)
{
    Console.WriteLine(i);
}

Console.WriteLine("Capacity: " + list.Capacity);

// Add 5 items to the list
for (int i = 0; i < 5; i++)
{
    list.Add(10 * i);
}

// Print list
foreach (var i in list)
{
    Console.WriteLine(i);
}

Console.WriteLine("Capacity: " + list.Capacity + "    Count: " + list.Count);

// Print list 
Console.WriteLine(string.Join(", ", list));

// Print array 
Console.WriteLine(string.Join(", ", arr));

// Console.WriteLine(list);