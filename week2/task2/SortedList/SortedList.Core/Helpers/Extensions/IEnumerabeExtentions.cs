using System.Collections.Generic;
using System.Linq;

namespace SortedList.Core.Helpers.Extensions
{
    public static class IEnumerabeExtentions
    {
        /// <summary>
        /// Returns true if collection inside implemented entity is sorted by descending.
        /// Otherwise, returns false.
        /// </summary>
        public static bool IsSorted<T>(this IEnumerable<T> source)
        {
            var count = source.Count();
            
            if (count is 0 or 1)
            {
                return true;
            }

            return source.SequenceEqual(source.OrderBy(val => val));
        }
    }
}