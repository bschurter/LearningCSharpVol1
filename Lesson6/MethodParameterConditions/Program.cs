using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace MethodParameterConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Validation
            // CalculateCircleArea(-5);  // This would throw an exception
            CalculateCircleCircumference(5);  // This passes validation

            // Custom trace listener
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new CustomTraceListener());

            // Debug & Trace Assert
            AddStudentGrade("", 50);
            AddStudentGrade("Joe", -10);

            // Contracts
            Contract.ContractFailed += (sender, e) =>
            {
                e.SetHandled(); // Prevent breaking into debugger
                e.SetUnwind();  // Guarantee an exception is thrown if one not manually thrown
                throw new InvalidOperationException($"Failed: {e.Message}");
            };

            DepositMoney(-5M);
        }

        static void ValidateRadius(double radius)
        {
            if (radius < 0) 
            { 
                throw new ArgumentOutOfRangeException(); 
            }
        }

        static double CalculateCircleArea(double radius)
        {
            ValidateRadius(radius);
            return Math.PI * radius * radius;
        }

        static double CalculateCircleCircumference(double radius)
        {
            ValidateRadius(radius);
            return 2.0 * Math.PI * radius;
        }

        static void AddStudentGrade(string student, int grade)
        {
            Debug.Assert(!string.IsNullOrEmpty(student), "Invalid student");
            Trace.Assert(grade >= 0 && grade <= 100, "Invalid grade");
            // Rest of code...
        }

        static void DepositMoney(decimal amount)
        {
            Contract.Assert(amount > 0, "Deposit must be positive");
            // Additional code ...
        }
    }

    internal class CustomTraceListener : TraceListener
    {
        public override void Write(string message) { /* Do nothing */ }
        public override void WriteLine(string message)
        {
            throw new InvalidOperationException(message);
        }
    }
}
