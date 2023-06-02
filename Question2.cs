using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    /*
    2.	Monotonic Array - An array is monotonic if it is either monotone increasing or monotone decreasing. 
        An array is monotone increasing if all its elements from left to right are non-decreasing. 
        [1,2,3,3]
        An array is monotone decreasing if all its elements from left to right are non-increasing. 
        [3,3,2,1]
        Given an integer array return true if the given array is monotonic, or false otherwise.
    */
    public class Question2
    {
        public void TestIsMonotonic()
        {
            var dataSet = new List<int[]>
            {
                new int[] {-1,1,2,3},       // yes
                new int[] {-20, -10, 100},       // yes
                new int[] {-0,0},       // yes
                new int[] {3,3,2,1},       // yes
                new int[] {3,4,2,1},       // no
            };
            dataSet.ForEach(testCaseData =>
            {
                Console.WriteLine($"{testCaseData.Display()} Is Monotonic ? {IsMonotonic(testCaseData).DisplayYesNo()}");
            });
        }

        public bool IsMonotonic(int[] array)
        {
            bool? isIncreasing = null;
            for (int i = 1; i < array.Length; i++)
            {
                // check if its increasing or decreasing
                if (isIncreasing == null)
                {
                    if (array[i] > array[i - 1])
                    {
                        isIncreasing = true;
                    }
                    else
                    {
                        isIncreasing = false;
                    }
                }

                // if increasing - check for violation (decrese) of it
                if (isIncreasing != null &&  isIncreasing.Value && array[i] < array[i - 1])
                {
                    return false;
                }

                // if decreasing - check for violation (increse) of it
                else if (isIncreasing != null && !isIncreasing.Value && array[i] > array[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}