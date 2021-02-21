using System;
using System.Collections;
using System.Collections.Generic;
using SortedList.Core.Interfaces;

namespace SortedList.Core.Implementations
{
    public class SortedList<T> : ISortedList<T>
        where T : IComparable
    {
        private readonly List<T> _items;
        public int Count => _items.Count;
        
        public SortedList(IEnumerable<T> items)
            => _items = items as List<T>;
        
        public SortedList()
            : this(new List<T>())
        { }
        
        public bool IsSortedByDescending()
        {
            if (Count == 0 || Count == 1)
            {
                return true;
            }

            return _items[0].CompareTo(_items[1]) < 0;
        }
        #region IEnumerable implementation
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (_items as IEnumerable).GetEnumerator();
        }
        #endregion
    }
}