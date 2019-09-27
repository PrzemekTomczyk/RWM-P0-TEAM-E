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
        public void CombinedFilterTestSimplePasses()
        {
            int[] inputArr = { 2 };
            int[] outputArr = CombinedFilter.combinedFilter(inputArr);
            int[] expected = { 2 };
            CollectionAssert.AreEqual(expected, outputArr);
        }
    }
}
