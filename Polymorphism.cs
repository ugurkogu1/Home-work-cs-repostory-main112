using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and assign values
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            // Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = employee1;

            // Call the Quit method using the IQuittable object
            quittableEmployee.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
