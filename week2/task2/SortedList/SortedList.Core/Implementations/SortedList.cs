using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SortedList.Core.Helpers.Extensions;
using SortedList.Core.Interfaces;

namespace SortedList.Core.Implementations
{
    public class SortedList<T> : ISortedList<T>
        where T : IComparable
    {
        private readonly List<T> _items;
        public int Count => _items.Count;

        public SortedList(IEnumerable<T> items)
        {
            if (items.IsSorted() is not true)
            {
                throw new ArgumentException("The source collection does not sorted!",
                    nameof(System.Collections.SortedList));
            }

            _items = items as List<T>;
        }
        public SortedList()
            : this(new List<T>())
        { }
        
        public void Add(T value)
       {
          _items.Add(value);
          // TODO: using Extension methods, add QuickSort to IEnumerable, that will extremely increase the performance. 
          _items.Sort();
       }
       public void AddRange(IEnumerable<T> values)
       {
           _items.AddRange(values);
           // TODO: using Extension methods, add QuickSort to IEnumerable, that will extremely increase the performance. 
           _items.Sort();
       }
       public bool Remove(T itemToRemove)
       {
           return _items.Remove(itemToRemove);
       }
       public int RemoveAll(Predicate<T> match)
       {
           return _items.RemoveAll(match);
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