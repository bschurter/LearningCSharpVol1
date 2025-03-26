string lastName = "Smith";
string firstName = "Bob";
long id = 123456789;
long phone = 8885551212;
decimal salary = 125_000.5788M;
DateTime dob = DateTime.Parse("1968-12-11");

string lastName2 = "Williamson";
string firstName2 = "Sally";
long id2 = 987645123;
long phone2 = 8001234567;
decimal salary2 = 2_125_000.95M;
DateTime dob2 = DateTime.Parse("1970-03-05");


string s1 = id + " " + lastName + " " + firstName + " " + dob + " " + phone + " " + salary;
Console.WriteLine(s1);

Console.WriteLine("{2,-11} {0,-15} {1,-15} {3,10} {4,14} {5,15}",  "Last Name", "First Name", "ID", "Birthday", "Phone", "Salary");
Console.WriteLine(new string('=', 85));
string format = "{2,-11:000-00-0000} {0,-15} {1,-15} {3,10:yyyy-MM-dd} {4,14:(000) 000-0000} {5,15:N2}";
string s2 = string.Format(format, lastName, firstName, id, dob, phone, salary);
Console.WriteLine(s2);
Console.WriteLine(format, lastName2, firstName2, id2, dob2, phone2, salary2);

Console.WriteLine($"{id2,-11:000-00-0000} {lastName2,-15} {firstName2,-15} {dob2,10:yyyy-MM-dd} {phone2,14:(000) 000-0000} {salary2,15:N2}");

PrintPerson(id, lastName, firstName, dob, phone, salary);

void PrintPerson(long id, string lastName, string firstName, DateTime dob, long phone, decimal salary)
{
    Console.WriteLine($"{id,-11:000-00-0000} {lastName,-15} {firstName,-15} {dob,10:yyyy-MM-dd} {phone,14:(000) 000-0000} {salary,15:C}");
}