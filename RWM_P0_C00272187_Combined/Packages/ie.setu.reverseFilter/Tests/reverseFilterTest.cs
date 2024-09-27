using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class ReverseFilterTest
    {
        [Test]
        public void ReverseFilterSimple()
        {
            int[] input = { 4, 3, 10, 1, 127 };
            int[] output = ReverseFilter.reverse(input);
            int[] expected = { 127, 1, 10, 3, 4 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}