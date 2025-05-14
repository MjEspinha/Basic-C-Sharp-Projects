using System;

namespace EmployeeEqualityApp
{

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //Checking if two employee objects are equal by comparing their id property
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (emp1 is null || emp2 is null)
                return false;

            return emp1.Id == emp2.Id;
        }


        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
                //Creating both employees Ids and comparing the two employee objects using the overloaded '==' operator
                Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Smith"
            };

            Employee emp2 = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones"
            };

            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 and emp2 are considered equal based on Id.");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 are NOT equal.");
            }

            Console.ReadLine();
        }
    }
}
