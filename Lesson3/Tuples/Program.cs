// Old syntax
var t1 = new Tuple<int, string, DateTime>(123, "John Doe", new DateTime(1950, 5, 6));
Console.WriteLine(t1);
Console.WriteLine(t1.Item1);
Console.WriteLine(t1.Item2);
Console.WriteLine(t1.Item3);
Console.WriteLine();

// Shortened syntax
var t2 = (123, "John Doe", new DateTime(1950, 5, 6));
Console.WriteLine(t2);
Console.WriteLine(t2.Item1);
Console.WriteLine(t2.Item2);
Console.WriteLine(t2.Item3);
Console.WriteLine();

// Named items
var t3 = (id: 123, name: "John Doe", dob: new DateTime(1950, 5, 6));
Console.WriteLine(t3);
Console.WriteLine(t3.id);
Console.WriteLine(t3.name);
Console.WriteLine(t3.dob);
Console.WriteLine();

// Implicitly named items
var id = 555;
var name = "Jane Smith";
var dob = DateTime.Parse("2005-11-10");
var t4 = (id, name, dob);
Console.WriteLine(t4);
Console.WriteLine(t4.id);
Console.WriteLine(t4.name);
Console.WriteLine(t4.dob);
Console.WriteLine();

// Using tuples as parameters and results
var pt = CreatePoint(3.1, 1.2);
Console.WriteLine(pt);
pt = MovePoint(pt, 3.7);
Console.WriteLine(pt);

(double x, double y) CreatePoint(double x, double y)
{
    return (x, y);
}

(double x, double y) MovePoint((double x, double y) pt, double offset)
{
    return (pt.x + offset, pt.y + offset);
}