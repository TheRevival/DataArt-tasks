using System;

namespace SortedList.Core.Helpers.Exceptions
{
    public class NonSortedCollectionException : ArgumentException
    {
        public NonSortedCollectionException()
        { }

        public NonSortedCollectionException(string message)
            : base(message)
        { }

        public NonSortedCollectionException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}