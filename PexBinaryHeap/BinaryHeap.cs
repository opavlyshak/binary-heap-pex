﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void Add(TPriority priority, TValue value)
        {
            items.Add(Tuple.Create(priority, value));
            BubbleUp(items.Count - 1);
        }

        public override string ToString()
        {
            return String.Join(", ", items.Select(it => it.Item1));
        }

        private void BubbleUp(int index)
        {
            if (index <= 0)
            {
                return;
            }
            var parentIndex = index/2;
            if (Less(index, parentIndex))
            {
                Swap(index, parentIndex);
                BubbleUp(parentIndex);
            }
        }

        private void Swap(int i, int j)
        {
            var temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        public void ObjectInvariant()
        {
            for (int i = 0; i < Count; i++)
            {
                var leftIndex = 2*i + 1;
                Debug.Assert(leftIndex >= Count || Less(i, leftIndex));

                var rightIndex = 2*i + 2;
                Debug.Assert(rightIndex >= Count || Less(i, rightIndex));
            }
        }

        private bool Less(int firstIndex, int secondIndex)
        {
            return comparer.Compare(
                items[firstIndex].Item1,
                items[secondIndex].Item1) <= 0;
        }
    }
}