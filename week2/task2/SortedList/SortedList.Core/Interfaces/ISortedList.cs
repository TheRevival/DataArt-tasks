using System.Collections.Generic;

namespace SortedList.Core.Interfaces
{
    public interface ISortedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Returns true if collection inside implemented entity is sorted by descending.
        /// Otherwise, returns false.
        /// </summary>
        /// <returns></returns>
        bool IsSortedByDescending();    
    }
}