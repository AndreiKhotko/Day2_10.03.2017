using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortNS
{
    /// <summary>
    /// Class that implements Merge sort
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Construct a sorted array A by merging two sorted arrays L and R
        /// </summary>
        /// <param name="A">Array to be need to sort</param>
        /// <param name="L">Left part of array A</param>
        /// <param name="R">Right part of array A</param>
        private static void Merge(int[] A, int[] L, int[] R)
        {
            int i = 0; // i - index of A
            int j = 0; // j - index of L
            int k = 0; // k - index of R

            while (j < L.Length && k < R.Length)
            {
                if (L[j] <= R[k])
                {
                    A[i++] = L[j++];
                }
                else
                {
                    A[i++] = R[k++];
                }
            }

            while (j < L.Length)
                A[i++] = L[j++];

            while (k < R.Length)
                A[i++] = R[k++];
        }

        /// <summary>
        /// Sort an array using merge algorithm
        /// </summary>
        /// <param name="array"></param>
        public static void Sort(int[] array)
        {
            int n = array.Length;

            if (n < 2)
                return;

            int middle = n / 2;

            // Divide our array into 2 parts. 
            int[] L = CopyArray(array, 0, middle - 1);
            int[] R = CopyArray(array, middle, n - 1);

            // Sort Left and Right parts of our array using a recursion
            Sort(L);
            Sort(R);

            // Merge sorted left and right parts
            Merge(array, L, R);            
        }

        /// <summary>
        /// Copy an array source from startIndex to endIndex
        /// </summary>
        /// <param name="source"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns>Destination array</returns>
        private static int[] CopyArray(int[] source, int startIndex, int endIndex)
        {
            int[] result = new int[endIndex - startIndex + 1];

            int j = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                result[j++] = source[i];
            }

            return result;
        }
    }
}
