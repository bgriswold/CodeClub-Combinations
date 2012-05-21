using System.Collections.Generic;
using System.Linq;

namespace Combinations
{
    public static class CombinationGenerator
    {
        /// <summary>
        /// Generate the combinations of K distinct objects chosen from the N elements of a list.           
        /// In how many ways can a committee of 3 be chosen from a group of 12 people? 
        /// We all know that there are C(12,3) = 220 possibilities (C(N,K) denotes the well-known binomial coefficient). 
        /// For pure mathematicians, this combinations may be great. But we want to really generate all the possibilities.
        /// 
        /// Example:
        /// scala> combinations(3, List('a, 'b, 'c, 'k, 'e, 'f))
        /// res0: List[List[Symbol]] = List(List('a, 'b, 'c), List('a, 'b, 'k), List('a, 'b, 'e), ...
        /// 
        /// http://aperiodic.net/phil/scala/s-99/ #26
        /// </summary>
        /// <typeparam name="T">Type of objects provided in list of elements</typeparam>
        /// <param name="k">Number of distinct objects per combination</param>
        /// <param name="elements">List of elements to base combinations</param> 
        /// <returns>Combinations of K distinct objects chosen from the N elements of a list.</returns>
        public static List<List<T>> Combinations<T>(int k, List<T> elements)
        {
            // Wrapper function used to initialize the combinations and index set. 
            // Wouldn't it be neat if we could new up these values as an optional parameter?
            return Combinations(k, elements, new List<List<T>>(), new List<int>());
        }
        
        /// <summary>
        /// Generate the combinations of K distinct objects chosen from the N elements of a list.           
        /// In how many ways can a committee of 3 be chosen from a group of 12 people? 
        /// We all know that there are C(12,3) = 220 possibilities (C(N,K) denotes the well-known binomial coefficient). 
        /// For pure mathematicians, this combinations may be great. But we want to really generate all the possibilities.
        /// </summary>
        /// <typeparam name="T">Type of objects provided in list of elements</typeparam>
        /// <param name="k">Number of distinct objects per combination</param>
        /// <param name="elements">List of elements to base combinations</param>
        /// <param name="combinations">List of combinations having been recursively generated</param>
        /// <param name="combinationIndexes">List of indexes using to build current combination from elements</param>
        /// <returns>Combinations of K distinct objects chosen from the N elements of a list.</returns>
        private static List<List<T>> Combinations<T>(int k, List<T> elements, List<List<T>> combinations, List<int> combinationIndexes)
        {
            // If we solved the problem with nested loops, each nested loop would 
            // iterate from (outer loop's start index + 1) to the n index.
            int start = combinationIndexes.Any()
                            ? combinationIndexes[combinationIndexes.Count - 1] + 1
                            : 0;

            // This is N as in N elements of a list. This value never changes through recursive calls.
            var end = elements.Count;
            
            for (int i = start; i < end; i++)
            {
                // Build the list of indexes for the current recursive iteration.
                // Indexes are used to determine the recursive depth.  
                // Once we hit the required depth (k), we build the combination by 
                // pulling elements per index from the elements list.
                var indexes = combinationIndexes
                    .Concat(new List<int> { i })
                    .ToList();

                if (k == indexes.Count)
                {
                    // The recursion depth (k) equals the number of elements per combination.
                    var combination = indexes
                        .Select(index => elements[index])
                        .ToList();

                    // Add the combination to list of found elements
                    combinations.Add(combination);
                }
                else
                {
                    // Our recursive depth is less than the required number of elements per combination (k).
                    // Continue to recursively call this function with the updated index set.
                    Combinations(k, elements, combinations, indexes);
                }
            }

            return combinations;
        }
    }
}
