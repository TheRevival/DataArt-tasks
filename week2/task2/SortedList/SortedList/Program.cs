using System;
using System.Collections.Generic;
using SortedList.Core.Implementations;

namespace SortedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var kek = new List<int>() { 3, 1, 2, 132, 200};

            var lol = new SortedList<int>(kek);

            foreach (var i in lol)
            {
                Console.WriteLine(i);
            }
        }

        private static void Kek(in int kekw)
        {
            
        }
    }
}