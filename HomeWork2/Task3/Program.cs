using System;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee employee = new Employee("Max", "Jonson")
            {
                Experience = 2,
                Position = "manager"
            };

            employee.ShowSalary();
        }
    }
}
