using System.Text;

int iterations = 10;
DateTime start = DateTime.Now;
DateTime end = DateTime.Now;

string s1 = "";
start = DateTime.Now;
for (int i = 0; i < iterations; i++)
{
    s1 += "A";
}
end = DateTime.Now;
Console.WriteLine($"Length: {s1.Length,8}, Duration: {end.Subtract(start).TotalMilliseconds,10:0.0000}");

// String Timings
// Length:       10, Duration:     0.0004
// Length:      100, Duration:     0.0040
// Length:     1000, Duration:     0.2686
// Length:    10000, Duration:    11.5053
// Length:   100000, Duration:   688.8090
// Length:  1000000, Duration: 85043.0053

StringBuilder sb = new StringBuilder();
start = DateTime.Now;
for (int i = 0; i < iterations; i++)
{
    sb.Append("A");
}
end = DateTime.Now;
Console.WriteLine($"Length: {sb.Length,8}, Duration: {end.Subtract(start).TotalMilliseconds,10:0.0000}");

// StringBuilder Timings
// Length:       10, Duration:     0.0008
// Length:      100, Duration:     0.0014
// Length:     1000, Duration:     0.0040
// Length:    10000, Duration:     0.0353
// Length:   100000, Duration:     0.4522
// Length:  1000000, Duration:     3.7671

StringBuilder sb2 = new StringBuilder("The quick brown fox jumps over the lazy dog.");
sb2 = sb2.Replace("fox", "bunny");
Console.WriteLine(sb2.ToString());
sb2.Insert(15, " happy");
Console.WriteLine(sb2.ToString());
sb2.Remove(4, 6);
Console.WriteLine(sb2.ToString());

string s2 = sb2.ToString();
