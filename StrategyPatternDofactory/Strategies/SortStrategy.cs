using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDofactory.Strategies
{
    public abstract class SortStrategy<T>
    {
        public abstract void Sort(List<T> list);
    }
}
