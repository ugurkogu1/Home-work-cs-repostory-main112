using System;

namespace EmployeeApp
{
    // Define the Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Properties for Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects based on their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Return true if both objects are not null and their Ids are equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to compare two Employee objects based on their Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals method to ensure proper behavior of '==' operator
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
            {
                return false;
            }
            return this.Id == ((Employee)obj).Id;
        }

        // Override GetHashCode method as Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}