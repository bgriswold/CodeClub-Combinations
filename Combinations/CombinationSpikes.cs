using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Combinations
{
    public class CombinationSpikes: TestBase
    {
        [Test]
        public void List_Of_5_Should_Return_10_Sets_Of_3()
        {
            var result = Loop(new List<int> { 1, 2, 3, 4, 5 });

            var expected = new List<List<int>>
                               {
                                   new List<int> {1, 2, 3}, 
                                   new List<int> {1, 2, 4}, 
                                   new List<int> {1, 2, 5}, 
                                   new List<int> {1, 3, 4}, 
                                   new List<int> {1, 3, 5}, 
                                   new List<int> {1, 4, 5}, 
                                   new List<int> {2, 3, 4}, 
                                   new List<int> {2, 3, 5}, 
                                   new List<int> {2, 4, 5}, 
                                   new List<int> {3, 4, 5}, 

                               };

            Assert(expected, result);
        }


        public static List<List<int>> Loop(List<int> elements)
        {
            var n = elements.Count; // number of elements

            var combinations = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        combinations.Add(new List<int> { elements[i], elements[j], elements[k] });
                    }
                }
            }

            return combinations;
        }

        [Test]
        public void List_Of_5_Should_Return_10_Sets_Of_3_Recursively()
        {
            var result = Combinations(3, new List<int> { 1, 2, 3, 4, 5 });

            var expected = new List<List<int>>
                               {
                                   new List<int> {1, 2, 3}, 
                                   new List<int> {1, 2, 4}, 
                                   new List<int> {1, 2, 5}, 
                                   new List<int> {1, 3, 4}, 
                                   new List<int> {1, 3, 5}, 
                                   new List<int> {1, 4, 5}, 
                                   new List<int> {2, 3, 4}, 
                                   new List<int> {2, 3, 5}, 
                                   new List<int> {2, 4, 5}, 
                                   new List<int> {3, 4, 5}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_1_Set_Of_5_Recursively()
        {
            var result = Combinations(5, new List<int> { 1, 2, 3, 4, 5 });

            var expected = new List<List<int>>
                               {
                                   new List<int> { 1, 2, 3, 4, 5 }
                               };

            Assert(expected, result);
        }

        public static List<List<int>> Combinations(int k, List<int> elements, List<List<int>> combinations = null, List<int> loopIndex = null)
        {
            if (combinations == null) combinations = new List<List<int>>();
            if (loopIndex == null) loopIndex = new List<int>();

            var n = elements.Count; // number of elements

            int start = 0;
            if (loopIndex.Count > 0)
                start = loopIndex[loopIndex.Count - 1] + 1;

            for (int i = start; i < n; i++)
            {
                var currentLoopIndex = loopIndex.Concat(new List<int> { i }).ToList();

                if (k == currentLoopIndex.Count)
                {
                    var nextCombination = currentLoopIndex.Select(index => elements[index]).ToList();
                    combinations.Add(nextCombination);
                }
                else
                {
                    Combinations(k, elements, combinations, currentLoopIndex);
                }
            }

            return combinations;
        }
        
        private static void GetCombinations(int k, List<int> elements, List<List<int>> combinations, List<int> loopIndex)
        {
            if (combinations == null) combinations = new List<List<int>>();
            if (loopIndex == null) loopIndex = new List<int>();

            var n = elements.Count;

            int start = 0;
            if (loopIndex.Count > 0)
                start = loopIndex[loopIndex.Count - 1] + 1;
            
            for (int i = start; i < n; i++)
            {
                var currentLoopIndex = loopIndex.Concat(new List<int> { i }).ToList();

                if (k == currentLoopIndex.Count)
                {
                    var nextCombination = currentLoopIndex.Select(index => elements[index]).ToList();
                    combinations.Add(nextCombination);
                }
                else
                {
                    GetCombinations(k, elements, combinations, currentLoopIndex);
                }
            }
        }

        private static void GetThird(List<int> elements, List<List<int>> combinations, List<int> current, int ctr)
        {
            var n = elements.Count;
            var j = current[current.Count - 1];
            for (int k = j + 1; k < n; k++)
            {
                var c = current.Concat(new List<int> { k }).ToList();

                if (ctr == c.Count)
                {
                    var r = c.Select(i => elements[i]).ToList();
                    combinations.Add(r);
                }
                else
                {
                    GetFourth(elements, combinations, c, ctr);    
                }
            }
        }

        private static void GetFourth(List<int> elements, List<List<int>> combinations, List<int> current, int ctr)
        {
            var n = elements.Count;
            var j = current[current.Count - 1];
            for (int k = j + 1; k < n; k++)
            {
                var c = current.Concat(new List<int> { k }).ToList();
                GetFifth(elements, combinations, c, ctr);
            }
        }

        private static void GetFifth(List<int> elements, List<List<int>> combinations, List<int> current, int ctr)
        {
            var n = elements.Count;
            var j = current[current.Count -1];
            for (int k = j + 1; k < n; k++)
            {
                var c = current.Concat(new List<int> { k }).ToList();

                if (ctr == c.Count)
                {
                    var r = c.Select(i => elements[i]).ToList();
                    combinations.Add(r);
                }
            }
        }
    }
}