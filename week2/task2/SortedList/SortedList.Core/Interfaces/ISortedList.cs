using System;
using System.Collections.Generic;

namespace SortedList.Core.Interfaces
{
    public interface ISortedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Returns true if collection inside implemented entity is sorted by descending.
        /// Otherwise, returns false.
        /// </summary>
        bool IsSorted();
    
        /// <summary>
        /// This method MUST keep contract that after every insert into collection it will be sorted.
        /// </summary>
        void Add(T value);
        
        /// <summary>
        /// This method MUST keep contract that after every insert into collection it will be sorted.
        /// </summary>
        void AddRange(IEnumerable<T> values);

        bool Remove(T itemToRemove);
        int RemoveAll (Predicate<T> match); 
    }
}