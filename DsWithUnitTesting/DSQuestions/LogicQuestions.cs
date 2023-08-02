namespace DSQuestions
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
                var toAdd = sum - array[i];
                if (dictionary.ContainsKey(toAdd))
                {
                    return new[] { i, dictionary[toAdd] };
                }
                dictionary.Add(array[i], i);    // key, value
            }
            return Array.Empty<int>();
        }

        public bool IsIsomorphic(string strOne, string strTwo)
        {
            if (string.IsNullOrWhiteSpace(strOne) || string.IsNullOrWhiteSpace(strTwo) || strOne.Length != strTwo.Length)
                return false;
            strOne = strOne.Trim();
            strTwo = strTwo.Trim();
            if (strOne.Length != strTwo.Length)
                return false;

            Dictionary<char, char> strOneDictionary = new() { { strOne[0], strTwo[0] } };       // k, v
            Dictionary<char, char> strTwoDictionary = new() { { strTwo[0], strOne[0] } };

            for (var i = 1; i < strOne.Length; i++)
            {
                if (strOneDictionary.ContainsKey(strOne[i]) && strOneDictionary[strOne[i]] != strTwo[i])
                {
                    return false;
                }
                if (strTwoDictionary.ContainsKey(strTwo[i]) && strTwoDictionary[strTwo[i]] != strOne[i])
                {
                    return false;
                }
                if (!strOneDictionary.ContainsKey(strOne[i]))
                    strOneDictionary.Add(strOne[i], strTwo[i]);
                if (!strTwoDictionary.ContainsKey(strTwo[i]))
                    strTwoDictionary.Add(strTwo[i], strOne[i]);
            }

            return true;
        }

        // In the Fibonacci sequence, each subsequent term is obtained by adding the preceding 2 terms.
        // This is true for all the numbers except the first 2 numbers of the Fibonacci series as they do not have 2 preceding numbers.
        // The first 2 terms in the Fibonacci series is 0 and 1.
        // F(n) = F(n-1)+F(n-2) for n>1.
        // Write a function that finds F(n) given n where n is an integer greater than equal to 0. For the first term n = 0. 
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        // Fib(0) => 0
        // Fib(1) => 1
        // Fib(2) => Fib(1) + Fib(0) => 1 + 0 => 1
        // Fib(3) => Fib(2) + Fib(1) => 1 + 1 => 2
        public int GetFibonacci(int num)
        {
            if (num == 0 || num == 1)
                return num;
            return GetFibonacci(num - 1) + GetFibonacci(num - 2);
        }
    }
}