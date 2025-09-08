using System;
using System.Collections.Generic;
using System.Linq;
namespace Median_of_Two_Sorted_Arrays
{
    public class Median_of_Two_Sorted_Arrays
    {
        public Median_of_Two_Sorted_Arrays(int[] nums1, int[] nums2)
        {
            int[] merged = new int[nums1.Length + nums2.Length];
            int i = 0, j = 0, k = 0;

            while (i < nums1.Length && j < nums2.Length)
                if (nums1[i] <= nums2[j]) merged[k++] = nums1[i++];
                else merged[k++] = nums2[j++];

            while (i < nums1.Length) merged[k++] = nums1[i++];
            while (j < nums2.Length) merged[k++] = nums2[j++];

            int mid = merged.Length / 2;

            if (merged.Length % 2 == 0) Console.WriteLine((merged[mid - 1] + merged[mid]) / 2.0);
            else Console.WriteLine(merged[mid]);
        }
    }
}
