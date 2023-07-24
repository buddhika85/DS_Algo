﻿namespace DSQuestions
{
    public class LogicQuestions
    {

        /*4.	Rotate Array - Given an array, rotate the array to the right by k steps, where k is non-negative.
        [1,2,3,4] => k = 1 => [4,1,2,3]
        [1,2,3,4] => k = 4 ==  length => [1,2,3,4]  ========= k % length == 0
        [1,2,3,4] => k = 8 ==  length => [1,2,3,4]  ========= k % length == 0


        [1,2,3,4] => k = 2 => [3,4,1,2]

        [1,2,3,4,5] => k = 2 => [3,4,5,1,2]
        */
        /// <summary>
        /// Rotates array
        /// </summary>
        /// <param name="array">Original array</param>
        /// <param name="k">Rotate steps</param>
        /// <returns></returns>
        public int[] RotateArrayByK(int[] array, int k)
        {
            if (k % array.Length == 0)
                return array;

            var rotatedArray = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                rotatedArray[(i + k) % array.Length] = array[i];
            }
            return rotatedArray;
        }

        public int[] Reverse(int[] array)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var temp = array[left];
                array[left--] = array[right];
                array[right--] = temp;
            }
            return array;
        }

        public int[] TwoSum(int[] array, int sum)
        {
            switch (array.Length)
            {
                case <= 1:
                    return Array.Empty<int>();
                case 2 when array[0] + array[1] == sum:
                    return new[] { 0, 1 };
            }

            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > sum)
                    continue;
                var toAdd = sum - array[i];
                if (dictionary.ContainsKey(toAdd))
                {
                    return new[] { i, dictionary[toAdd] };
                }
                dictionary.Add(array[i], i);    // key, value
            }
            return Array.Empty<int>();
        }

    }
}