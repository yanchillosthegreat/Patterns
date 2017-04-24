using StrategyPatternDofactory.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDofactory
{
    public class SortedList<T>
    {
        private List<T> list;
        private SortStrategy<T> sortStrategy;

        public SortedList()
        {
            list = new List<T>();
        }

        public SortedList(SortStrategy<T> sortStrategy) : this()
        {
            this.sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(SortStrategy<T> sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Sort()
        {
            sortStrategy.Sort(list);
        }

        public void PrintList()
        {
            foreach (var item in list)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine();
        }
    }
}
