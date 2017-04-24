using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDofactory.Strategies
{
    public class QuickSort<T> : SortStrategy<T>
    {
        public override void Sort(List<T> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list ");
        }
    }
}
