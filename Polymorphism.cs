using System;

namespace InterfacePolymorphismApp
{
    //Create an interface called IQuittable and have it define a void method called Quit()
    interface IQuittable
    {
        void Quit();
    }

    class Employee : IQuittable
    {
        // Property: First name of the employee
        public string FirstName { get; set; }

        // Property: Last name of the employee
        public string LastName { get; set; }

        // Implement the Quit method as required by the IQuittable interface
        public void Quit()
        {
            // Display a message indicating that the employee has quit
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee and set properties
            Employee employee = new Employee
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Use polymorphism by assigning the employee to a variable of type IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit method using the IQuittable interface
            quittableEmployee.Quit();
            Console.ReadLine();
        }
    }
}


