using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person(int id, string lastName, string firstName, DateTime dob)
    {
        // These fields are assigned when the primary constructor is called
        public int ID = id;
        public string LastName = lastName;
        public string FirstName = firstName;
        public DateTime DOB = dob;

        public Person() : this(0, string.Empty, string.Empty, DateTime.MinValue) { }

        public Person(Person other) : this(other.ID, other.LastName, other.FirstName, other.DOB)  { }

        public int GetAge()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - this.DOB.Year;  // this. is superfluous
            if (DOB.Date > now.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        public static string GetHeader()
        {
            return $"{"ID",-11} {"Last Name",-15} {"First Name",-15} {"DOB (Age)",-16}{Environment.NewLine}{new string('=', 60)}";
        }

        public override string ToString()
        {
            return $"{ID,11:000-00-0000} {LastName,-15} {FirstName,-15} {DOB,10:yyyy-MM-dd} ({GetAge(),3})";
        }
    }
}
