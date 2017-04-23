﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Factories
{
    class ComparerFactory
    {
        public static IComparer<T> Create<T>(Comparison<T> comparer)
        {
            return new DelegateComparer<T>(comparer);
        }

        private class DelegateComparer<T> : IComparer<T>
        {
            private readonly Comparison<T> comparer;

            public DelegateComparer(Comparison<T> comparer)
            {
                this.comparer = comparer;
            }

            public int Compare(T x, T y)
            {
                return comparer(x, y);
            }
        }
    }
}
