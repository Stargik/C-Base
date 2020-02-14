using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Employee
    {
        readonly string name, surname;
        string position;
        int experience;

        public string Position { get => position; set => position = value; }
        public int Experience { get => experience; set => experience = value; }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        decimal CountSalary()
        {
            decimal salary = 0m;

            switch (position.ToLower())
            {
                case "manager":
                    salary = 3000m;
                    break;
                case "ingener":
                    salary = 4000m;
                    break;
                case "programer":
                    salary = 5000m;
                    break;
                default:
                    Console.WriteLine("Position is not exist.");
                    break;
            }

            switch (experience)
            {
                case 1:
                    salary *= 2;
                    break;
                case 2:
                    salary *= 3;
                    break;
                case 3:
                    salary *= 4;
                    break;
                default:
                    salary *= experience > 1 ? 4 : 1;
                    break;
            }

            return salary;
            
        }

        public void ShowSalary()
        {
            Console.WriteLine($"Surname: {surname}\nName: {name}\nSalary: {CountSalary()}\nNalog: {CountSalary() * 0.15m}");
        }
       

    }
}
