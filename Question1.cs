using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    /*
    1.	Sorted Squared Array - 
    You are given an array of Integers in which each subsequent value is not less than the previous value. 
    Write a function that takes this array as an input and returns a new array with the squares of each number sorted in ascending order.
    */
    public class Question1
    {

        public void TestSortedSquaredArray()
        {
            var dataSet = new List<(int[], int[])>
            {
                new (new int[] {-7,-1,0,4,5,6}, new int[] {0,1,16,25,36,49}),
                new (new int[] {-7,-5,-0,1,3,5}, new int[] {0,1,9,25,25,49})
            };
            dataSet.ForEach(testCaseData => {
                var result = SortedSquaredArray(testCaseData.Item1);
                if (!Enumerable.SequenceEqual(result, testCaseData.Item2))
                {
                    Console.WriteLine($"Failed => {testCaseData.Item1.Display()} did not produce {testCaseData.Item2.Display()}, but produced {result.Display()}");
                }
                else
                {
                    Console.WriteLine($"Passed=> {testCaseData.Item1.Display()} result is {result.Display()}");
                }
            });
        }

        public int[] SortedSquaredArray(int[] array)
        {
            var left = 0;
            var right =  array.Length - 1;
            var sortedSquaredArray = new int[array.Length];
            var index = sortedSquaredArray.Length - 1;
            while(index >= 0)
            {
                var leftSquared = array[left] * array[left];
                var rightSquared = array[right] * array[right];
                if (leftSquared >= rightSquared)
                {
                    sortedSquaredArray[index] = leftSquared;
                    ++left;
                }
                else
                {
                    sortedSquaredArray[index] = rightSquared;
                    --right;
                }
                --index;
            }
            return sortedSquaredArray;
        }
    }
}