using System;
using System.Collections.Generic;

namespace SortedList.Core.Interfaces
{
    public interface ISortedList<T> : IEnumerable<T>
    {

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