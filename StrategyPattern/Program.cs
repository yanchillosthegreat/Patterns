using StrategyPattern.Comparers;
using StrategyPattern.Factories;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesOriginal = new List<Employee>
            {
                new Employee { Id = 5, Name = "F"},
                new Employee { Id = 4, Name = "E"},
                new Employee { Id = 3, Name = "D"},
                new Employee { Id = 2, Name = "C"},
                new Employee { Id = 1, Name = "B"},
                new Employee { Id = 0, Name = "A"}
            };

            // Sorting Via Delegate.
            var employees = new List<Employee>(employeesOriginal);
            employees.Sort((x, y) => x.Name.CompareTo(y.Name));
            PrintList(employees);

            // Sorting Via IComparer-Functor.
            employees = new List<Employee>(employeesOriginal);
            employees.Sort(new ByEmployeeIdComparer());
            PrintList(employees);

            // Sorting Via Delegate Which Is Wrapped Into IComparer-Functor.
            employees = new List<Employee>(employeesOriginal);
            var comparer = ComparerFactory.Create<Employee>((x, y) => x.Id.CompareTo(y.Id));
            var sortedSet = new SortedSet<Employee>(employees, comparer);
            PrintList(sortedSet);
        }

        static void PrintList(IEnumerable<object> objects)
        {
            foreach (var @object in objects)
            {
                Console.WriteLine(@object.ToString());
            }
            Console.WriteLine();
        }
    }
}
