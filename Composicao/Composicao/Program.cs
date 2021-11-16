using Composicao.Entities;
using Composicao.Entities.Enums;
using System;
using System.Globalization;

namespace Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Department depto = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, depto);
            Console.Write("How many contracts to this worker? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdContracts; i++)
            {
                Console.WriteLine($"Enter Contract #{i}: ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration(Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));
            Console.WriteLine($"Income: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
