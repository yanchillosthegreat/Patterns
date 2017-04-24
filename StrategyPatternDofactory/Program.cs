using StrategyPatternDofactory.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDofactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string> studentRecords = new SortedList<string>(new QuickSort<string>());

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.Sort();
            studentRecords.PrintList();

            SortedList<int> numbers = new SortedList<int>();

            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(5);
            numbers.Add(25);
            numbers.Add(20);

            numbers.SetSortStrategy(new MergeSort<int>());
            numbers.Sort();
            numbers.PrintList();
        }
    }
}
