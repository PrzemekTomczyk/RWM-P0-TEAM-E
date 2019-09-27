using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterTestPass()
        {
            int[] inputArr = { 0, 1, 2, 3, 4, 5, 696969420 };
            int[] outputArr = CombinedFilter.combinedFilter(inputArr);
            int[] expected = { 0, 2, 4, 5, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, outputArr);
        }
        [Test]
        public void CombinedFilterTestFail()
        {
            int[] inputArr = { 0, 1, 2, 3, 4, 5 };
            int[] outputArr = CombinedFilter.combinedFilter(inputArr);
            int[] expected = { 8, 7, 5, 4, 2, 0 };
            CollectionAssert.AreNotEqual(expected, outputArr);
        }
    }
}
