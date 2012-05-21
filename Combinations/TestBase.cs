using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
namespace Combinations
{
    public class TestBase
    {
        protected static void Assert(IEnumerable<List<int>> expected, List<List<int>> actual)
        {
            foreach (var r in actual)
            {
                Console.WriteLine(String.Join(",", r.ToArray()));
            }

            CollectionAssert.AreEquivalent(expected, actual);
        }

        protected static void Assert<T>(IEnumerable<List<T>> expected, List<List<T>> actual)
        {
            foreach (var r in actual)
            {
                Console.WriteLine(String.Join(",", r.ToArray()));
            }

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
