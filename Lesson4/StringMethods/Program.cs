//                           1         2         3         4
//                 01234567890123456789012345678901234567890123
string sentence = "The quick brown fox jumps over the lazy dog.";

//==========================================
// Searching and Comparing
//==========================================
string s1 = "Abc";
string s2 = "abc";
// For compares:   <0: s1 < s2   0: s1 == s2   >0: s2 > s1
Console.WriteLine( s1.CompareTo(s2));
Console.WriteLine(string.Compare(s1, s2));
Console.WriteLine(string.Compare(s1, s2, true));

Console.WriteLine("Contains 'fox': " + sentence.Contains("fox"));   // Exact match
Console.WriteLine("Contains 'Fox': " + sentence.Contains("Fox", StringComparison.CurrentCultureIgnoreCase));  // Case-insensitive match

Console.WriteLine("Index of 'fox': " + sentence.IndexOf("fox"));   // Exact match, -1 if not found
Console.WriteLine("Index of 'Fox': " + sentence.IndexOf("Fox", StringComparison.CurrentCultureIgnoreCase));   // Case-insensitive match, -1 if not found

Console.WriteLine("Index of 'The': " + sentence.IndexOf("The", 1, StringComparison.CurrentCultureIgnoreCase));   // Case-insensitive match, starting at index 1, -1 if not found
Console.WriteLine("Last Index of 'The': " + sentence.LastIndexOf("The", StringComparison.CurrentCultureIgnoreCase));   // Case-insensitive match, -1 if not found

Console.WriteLine("Starts with 'The': " + sentence.StartsWith("The"));
Console.WriteLine("Ends with '!': " + sentence.EndsWith("!"));

string s3 = string.Empty;   // ""
string s4 = null;
Console.WriteLine("s2 is null or empty? " + string.IsNullOrEmpty(s2));
Console.WriteLine("s3 is null or empty? " + string.IsNullOrEmpty(s3));
Console.WriteLine("s4 is null or empty? " + string.IsNullOrEmpty(s4));


//==========================================
// Manipulation
//==========================================
string s5 = "This is test";
string s5a = s5.Insert(8, "a ");
Console.WriteLine(s5a);
string s5b = s5a.Remove(8, 2);
Console.WriteLine(s5b);
string s5c = s5.Replace("test", "a test");
Console.WriteLine(s5c);
string s5d = s5c.Substring(5, 2);  // Grab "is" from s5c
Console.WriteLine(s5d);
var words = sentence.Split(' ');
foreach (var word in words)
{
    Console.WriteLine(word);
}
string ssn = "111,22,3333";
var ssnParts = ssn.Split(',');
Console.WriteLine(string.Join("-", ssnParts));
int[] arr = { 1, 1, 2, 3, 5, 8, 13 };
Console.WriteLine(string.Join(", ", arr));

//==========================================
// Formatting
//==========================================
string s6 = "AbcDEfG";
Console.WriteLine(s6.ToUpper());
Console.WriteLine(s6.ToLower());
string s7 = "     ab cde    ";
string s7a = s7.TrimEnd();
Console.WriteLine("[" + s7a + "]");
string s7b = s7.TrimStart();
Console.WriteLine("[" + s7b + "]");
string s7c = s7.Trim();
Console.WriteLine("[" + s7c + "]");

string s8 = "ABC";
string s8a = s8.PadLeft(7);
Console.WriteLine("[" + s8a + "]");
string s8b = s8.PadRight(7, '*');
Console.WriteLine("[" + s8b + "]");
string s8c = s8.PadLeft(2);
Console.WriteLine("[" + s8c + "]");