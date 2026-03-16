using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee()
            {
                Id = 101,
                FirstName = "Ali",
                LastName = "Khan"
            };


            Employee emp2 = new Employee()
            {
                Id = 101,
                FirstName = "Ahmed",
                LastName = "Raza"
            };

            bool areEqual = emp1 == emp2;

            Console.WriteLine("Are the two employees equal? " + areEqual);

            bool areNotEqual = emp1 != emp2;

            Console.WriteLine("Are the two employees NOT equal? " + areNotEqual);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
