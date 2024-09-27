using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class SortFilterTest
    {
        [Test]
        public void SortFilterSimple()
        {
            int[] input = { 13, 7, 2, 8, 3, 9, 10, 5, 11, 6 };
            int[] output = SortFilter.sort(input);
            int[] expected = { 2, 3, 5, 6, 7, 8, 9, 10, 11, 13 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}