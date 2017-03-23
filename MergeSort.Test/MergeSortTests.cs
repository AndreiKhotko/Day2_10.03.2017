using System;
using System.Linq;
using NUnit.Framework;

namespace MergeSort.Test
{
    [TestFixture]
    public class MergeSortTests
    {
        [TestCase(null)]
        public void Sort_NullRef_ShouldThrowArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => MergeSortNS.MergeSort.Sort(array));
        }

        [TestCase(new int[1] { 1 })]
        [TestCase(new int[1] { -1 })]
        public void Sort_OneElementArray_PositiveTest(int[] array)
        {
            int[] expected = new int[1];
            array.CopyTo(expected, 0);

            int[] actual = new int[1];
            array.CopyTo(actual, 0);
            MergeSortNS.MergeSort.Sort(actual);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCase(new int[8] { 1, 2, 3, 6, 1, 5, 4, 0 })]
        [TestCase(new int[7] { 0, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[7] { -1, 1000, -2, 0, -1, 5, 6 })]
        [TestCase(new int[7] { 6, 5, 4, 3, 2, 1, 0 })]
        public void Sort_MoreThanOneElementArray_PositiveTest(int[] array)
        {
            int[] expected = new int[array.Length];
            array.CopyTo(expected, 0);
            Array.Sort(expected);

            int[] actual = new int[array.Length];
            array.CopyTo(actual, 0);
            MergeSortNS.MergeSort.Sort(actual);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
