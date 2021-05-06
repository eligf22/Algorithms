using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPracticeLibrary
{
    public class BinarySearch
    {
        public static int IsBinarySearch(int[] sortedArray, int searchNum, int leftIndex, int rightIndex)
        {
            if (rightIndex >= leftIndex)
            {
                int middleIndex = leftIndex + (rightIndex -1) / 2;
                if (sortedArray[middleIndex] == searchNum)
                {
                    return middleIndex;
                }

                if (searchNum > sortedArray[middleIndex])
                {
                    return IsBinarySearch(sortedArray, searchNum, middleIndex + 1, rightIndex);
                }
                else
                {
                    return IsBinarySearch(sortedArray, searchNum, leftIndex, middleIndex - 1);
                }
            }
            return -1;
        }
    }
}
