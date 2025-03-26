namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For the demo, DateTime.Now was 2025-03-01
            List<Person> list = new List<Person>();
            
            list.Add(new Person() { ID = 123456789, LastName = "Smith", FirstName = "John", DOB = new DateTime(2000, 02, 05) });
            Person p2 = new Person(list.First());
            Person p3 = new Person(999888774, "Williams", "Sarah", new DateTime(1999, 02, 11));

            list.Add(p2);
            list.Add(p3);

            Console.WriteLine(Person.GetHeader());
            foreach (var p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
