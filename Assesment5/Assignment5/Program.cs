﻿namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            string input;
            char ch;

            do
            {
                Console.Write("Enter employee type (contractbase/payroll)  ");
                input = Console.ReadLine().ToLower();
                Console.Write("Enter ID: ");
                int uid = int.Parse(Console.ReadLine());
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter reporting manager: ");
                string reportingManager = Console.ReadLine();
                if (input == "contractbase")
                {
                    Console.Write("Enter contract date (dd-mm-yyyy): ");
                    DateTime contractDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter duration : ");
                    int duration = int.Parse(Console.ReadLine());
                    Console.Write("Enter charges: ");
                    double charges = double.Parse(Console.ReadLine());
                    employees.Add(new ContractBaseEmp(uid, name, reportingManager, contractDate, duration, charges));
                }
                else if (input == "payroll")
                {
                    Console.Write("Enter joining date (dd-mm-yyyy): ");
                    DateTime joiningDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter experience (in years): ");
                    int experience = int.Parse(Console.ReadLine());

                    Console.Write("Enter basic salary: ");
                    decimal basicSalary = decimal.Parse(Console.ReadLine());

                    employees.Add(new PayrollEmp(uid, name, reportingManager, joiningDate, experience, basicSalary));
                }
                else
                {
                    Console.WriteLine("Invalid employee");
                }

                Console.WriteLine("Do you want to add Employee(y/n)");
                ch = char.Parse(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');

            foreach (var employee in employees)
            {
                employee.DisplayDetails();
            }

            Console.WriteLine($"Total Number of Employees: {employees.Count}");
        }
    }
}
