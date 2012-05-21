using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
namespace Combinations
{
    public class CombinationGeneratorTests : TestBase
    {
        [Test]
        public void List_Of_1_Should_Return_0_Sets_Of_2()
        {
            var result = CombinationGenerator.Combinations(2, Enumerable.Range(1, 1).ToList());

            var expected = new List<List<int>>
            {

            };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_1_Should_Return_1_Set_Of_1()
        {
            var result = CombinationGenerator.Combinations(1, Enumerable.Range(1, 1).ToList());

            var expected = new List<List<int>>
                               {
                                   new List<int> {1}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_2_Should_Return_0_Sets_Of_3()
        {
            var result = CombinationGenerator.Combinations(3, Enumerable.Range(1, 2).ToList());

            var expected = new List<List<int>>
            {

            };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_2_Should_Return_1_Set_Of_2()
        {
            var result = CombinationGenerator.Combinations(2, Enumerable.Range(1, 2).ToList());

            var expected = new List<List<int>>
                               {
                                   new List<int> {1, 2}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_2_Should_Return_2_Sets_Of_1()
        {
            var result = CombinationGenerator.Combinations(1, Enumerable.Range(1, 2).ToList());

            var expected = new List<List<int>>
                               {
                                   new List<int> {1}, 
                                   new List<int> {2}
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_3_Should_Return_1_Set_Of_3()
        {
            var result = CombinationGenerator.Combinations(3, Enumerable.Range(1, 3).ToList());

            var expected = new List<List<int>>
                               {
                                   new List<int> {1, 2, 3}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_3_Should_Return_3_Sets_Of_2()
        {
            var result = CombinationGenerator.Combinations(2, Enumerable.Range(1, 3).ToList());

            var expected = new List<List<int>>
                               {
                                   new List<int> {1, 2}, 
                                   new List<int> {1, 3}, 
                                   new List<int> {2, 3}
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_3_Should_Return_0_Sets_Of_4()
        {
            var result = CombinationGenerator.Combinations(4, Enumerable.Range(1, 3).ToList());

            var expected = new List<List<int>>
            {

            };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_4_Should_Return_1_Sets_Of_4()
        {
            var result = CombinationGenerator.Combinations(4, Enumerable.Range(1, 4).ToList());

            var expected = new List<List<int>>
                               {
                                   new List<int> {1, 2, 3, 4}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_4_Should_Return_4_Sets_Of_3()
        {
            var result = CombinationGenerator.Combinations(3, Enumerable.Range(1, 4).ToList());

            var expected = new List<List<int>>
                               {
                                   new List<int> {1, 2, 3}, 
                                   new List<int> {1, 2, 4}, 
                                   new List<int> {1, 3, 4}, 
                                   new List<int> {2, 3, 4}
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_0_Sets_Of_6()
        {
            var result = CombinationGenerator.Combinations(6, new List<int> { 1, 2, 3, 4, 5 });

            var expected = new List<List<int>>
            {

            };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_5_Sets_Of_1()
        {
            var result = CombinationGenerator.Combinations(1, new List<int> { 1, 2, 3, 4, 5 });

            var expected = new List<List<int>>
                               {
                                   new List<int> {1}, 
                                   new List<int> {2}, 
                                   new List<int> {3}, 
                                   new List<int> {4}, 
                                   new List<int> {5}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_10_Sets_Of_3()
        {
            var result = CombinationGenerator.Combinations(3, new List<int> { 1, 2, 3, 4, 5 });

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
        public void List_Of_5_Should_Return_1_Set_Of_5()
        {
            var result = CombinationGenerator.Combinations(5, new List<int> { 1, 2, 3, 4, 5 });

            var expected = new List<List<int>>
                               {
                                   new List<int> { 1, 2, 3, 4, 5 }
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_0_Sets_Of_6_Chars()
        {
            var result = CombinationGenerator.Combinations(6, new List<char> { 'a', 'b', 'c', 'd', 'e' });

            var expected = new List<List<char>>
            {

            };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_5_Sets_Of_1_Chars()
        {
            List<List<char>> result = CombinationGenerator.Combinations(1, new List<char> { 'a', 'b', 'c', 'd', 'e' });

            var expected = new List<List<char>>
                               {
                                   new List<char> {'a'}, 
                                   new List<char> {'b'}, 
                                   new List<char> {'c'}, 
                                   new List<char> {'d'}, 
                                   new List<char> {'e'}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_10_Sets_Of_3_Chars()
        {
            var result = CombinationGenerator.Combinations(3, new List<char> { 'a', 'b', 'c', 'd', 'e' });

            var expected = new List<List<char>>
                               {
                                   new List<char> {'a', 'b', 'c'}, 
                                   new List<char> {'a', 'b', 'd'}, 
                                   new List<char> {'a', 'b', 'e'}, 
                                   new List<char> {'a', 'c', 'd'}, 
                                   new List<char> {'a', 'c', 'e'}, 
                                   new List<char> {'a', 'd', 'e'}, 
                                   new List<char> {'b', 'c', 'd'}, 
                                   new List<char> {'b', 'c', 'e'}, 
                                   new List<char> {'b', 'd', 'e'}, 
                                   new List<char> {'c', 'd', 'e'}, 
                               };

            Assert(expected, result);
        }

        [Test]
        public void List_Of_5_Should_Return_1_Set_Of_5_Chars()
        {
            var result = CombinationGenerator.Combinations(5, new List<char> { 'a', 'b', 'c', 'd', 'e' });

            var expected = new List<List<char>>
                               {
                                   new List<char> { 'a', 'b', 'c', 'd', 'e' }
                               };

            Assert(expected, result);
        }
    }
}
