﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace PexBinaryHeap
{
    public class BinaryHeap<TPriority, TValue>
    {
        private readonly List<Tuple<TPriority, TValue>> items = 
            new List<Tuple<TPriority, TValue>>();

        private readonly Comparer<TPriority> comparer = Comparer<TPriority>.Default; 

        public int Count
        {
            get { return items.Count; }
        }

        public BinaryHeap()
        {
            Contract.Ensures(Count == 0);
        }

        public void Add(TPriority priority, TValue value)
        {
            Contract.Ensures(Count == Contract.OldValue(Count) + 1);

            items.Add(Tuple.Create(priority, value));
            BubbleUp(items.Count - 1);
        }

        public TValue GetValue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot extract element from empty heap.");
            }
            return items[0].Item2;
        }

        public override string ToString()
        {
            return String.Join(", ", items.Select(it => it.Item1));
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(HeapPropertyIsSatisfied());
            Contract.Invariant(items != null);
            Contract.Invariant(Contract.ForAll(items, item => item != null));
            Contract.Invariant(comparer != null);
            Contract.Invariant(Count >= 0);
        }

        [Pure]
        private bool HeapPropertyIsSatisfied()
        {
            for (int i = 0; i < Count; i++)
            {
                var leftIndex = 2 * i + 1;
                if (leftIndex < Count && !Less(i, leftIndex))
                {
                    return false;
                }

                var rightIndex = 2 * i + 2;
                if (rightIndex < Count && !Less(i, rightIndex))
                {
                    return false;
                }
            }
            return true;
        }

        private void BubbleUp(int index)
        {
            Contract.Requires(0 <= index && index < Count);

            if (index <= 0)
            {
                return;
            }
            var parentIndex = (index - 1)/2;
            if (Less(index, parentIndex))
            {
                Swap(index, parentIndex);
                BubbleUp(parentIndex);
            }
        }

        private void Swap(int leftIndex, int rightIndex)
        {
            Contract.Requires(0 <= leftIndex && leftIndex <= Count);
            Contract.Requires(0 <= rightIndex && rightIndex <= Count);
            
            var temp = items[leftIndex];
            items[leftIndex] = items[rightIndex];
            items[rightIndex] = temp;
        }

        private bool Less(int leftIndex, int rightIndex)
        {
            Contract.Requires(0 <= leftIndex && leftIndex <= Count);
            Contract.Requires(0 <= rightIndex && rightIndex <= Count);

            return comparer.Compare(
                items[leftIndex].Item1,
                items[rightIndex].Item1) <= 0;
        }
    }
}
