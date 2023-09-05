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


        private readonly Dictionary<int, int> _fibNumbers = new();      // key, fib(key)

        public int GetFibonacciWithMemoization(int num)
        {
            if (num == 0 || num == 1)
                return num;

            int prevOne;
            if (_fibNumbers.ContainsKey(num - 1))
            {
                prevOne = _fibNumbers[num - 1];
                _fibNumbers.Add(num - 1, prevOne);
            }
            else
            {
                prevOne = GetFibonacci(num - 1);
            }

            int prevTwo;
            if (_fibNumbers.ContainsKey(num - 2))
            {
                prevTwo = _fibNumbers[num - 2];
                _fibNumbers.Add(num - 2, prevTwo);
            }
            else
            {
                prevTwo = GetFibonacci(num - 2);
            }

            return prevOne + prevTwo;
        }

        // returns first non-repeating characters index
        // A a b 1 A c d => non repeating is a => returns index of a which is 1
        // a a 1 1 A A => all chars repeat => so return null
        public int? GetFirstNonRepeatingIndex(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return null;

            Dictionary<char, int> charsWithIndex = new();       // key = character , value = index
            for (var i = 0; i < str.Length; i++)
            {
                if (charsWithIndex.ContainsKey(str[i]))
                {
                    // it repeats - so no need to store
                    charsWithIndex.Remove(str[i]);
                }
                else
                {
                    charsWithIndex.Add(str[i], i);
                }
            }

            if (charsWithIndex.Any())
                return charsWithIndex.First().Value;
            return null;
        }

        public bool IsPalindrome(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            if (str.Length == 1)
                return true;

            var left = 0;
            var right = str.Length - 1;
            while (left < right)
            {
                if (str[left++] != str[right--])
                    return false;
            }
            return true;
        }

        // array needs to be sorted
        public int BinarySearch(int[] array, int value)
        {
            // validations
            if (!array.Any() || value < array[0] || value > array[array.Length - 1])
                return -1;

            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (array[middle] == value)
                    return middle;
                if (array[middle] > value)
                    right = middle - 1;
                if (array[middle] < value)
                    left = middle + 1;
            }

            return -1;      // not found
        }

        // array needs to be sorted 
        public int RecursiveBinarySearch(int[] array, int value, int left, int right)
        {
            // validations
            if (!array.Any() || value < array[0] || value > array[array.Length - 1])
                return -1;

            var middle = (left + right) / 2;
            if (array[middle] == value)
                return middle;
            if (array[middle] > value)
                right = middle - 1;
            if (array[middle] < value)
                left = middle + 1;
            return RecursiveBinarySearch(array, value, left, right);
        }

        // [] target = 10 --> -1 not found
        // [1,2,3,4,5]  target = 3 --> index 2 
        // [3,4,5,1,2]  target = 3 --> index 0 
        public int SortedRotatedSearch(int[] array, int target)
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (array[middle] == target)
                    return middle;
                if (array[left] <= array[middle])
                {
                    // left part is sorted
                    if (target >= array[left] && target < array[middle])
                    {
                        // explore left
                        right = middle - 1;
                    }
                    else
                    {
                        // explore right
                        left = middle + 1;
                    }
                }
                else
                {
                    // right part is sorted
                    if (target > array[middle] && target <= array[right])
                    {
                        // explore right
                        left = middle + 1;
                    }
                    else
                    {
                        // explore left
                        right = middle - 1;
                    }
                }
            }

            return -1;
        }


        public int RecursiveSortedRotatedSearch(int[] array, int target, int left, int right)
        {
            var middle = (left + right) / 2;
            if (array[middle] == target)
                return middle;
            if (array[left] <= array[middle])
            {
                // left part is sorted
                if (target >= array[left] && target < array[middle])
                {
                    // explore left
                    right = middle - 1;
                }
                else
                {
                    // explore right
                    left = middle + 1;
                }

                return RecursiveSortedRotatedSearch(array, target, left, right);
            }
            else
            {
                // right part is sorted
                if (target > array[middle] && target <= array[right])
                {
                    // explore right
                    left = middle + 1;
                }
                else
                {
                    // explore left
                    right = middle - 1;
                }

                return RecursiveSortedRotatedSearch(array, target, left, right);
            }
            return -1;
        }

        // [1,2,2,2,3] , t = 2 -> [1,3]
        // [1,2,2,2,3] , t = 3 -> [4,4
        // [1,2,2,2,3] , t = 4 -> [-1,-1]
        public int[] FindFirstAndLastIndex(int[] array, int target)
        {
            if (array.Length == 1 && array[0] == target)
            {
                return new[] { 0, 0 };
            }
            if (array.Length == 1 && array[0] != target)
            {
                return new[] { -1, -1 };
            }

            return new[] { FindLeftExtreme(target, array), FindRightExtreme(target, array) };
        }

        private int FindRightExtreme(int target, int[] array)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (array[middle] == target)
                {
                    var afterMiddle = middle + 1;
                    if (afterMiddle > array.Length - 1 || array[afterMiddle] > target)
                    {
                        // found right extreme
                        return middle;
                    }

                    // search right for more right extreme
                    left = middle + 1;
                }
                else if (array[middle] < target)
                {
                    // go right
                    left = middle + 1;
                }
                else //if (array[middle] > target)
                {
                    // go left
                    right = middle - 1;
                }
            }
            return -1;
        }

        private int FindLeftExtreme(int target, int[] array)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (array[middle] == target)
                {
                    var beforeMiddle = middle - 1;
                    // go left and see
                    if (beforeMiddle < 0 || array[beforeMiddle] < target)
                    {
                        // found left extreme
                        return middle;
                    }

                    // go more to left
                    right = middle - 1;
                }
                else if (array[middle] < target)
                {
                    left = middle + 1;
                }
                else //if (array[middle] > target)
                {
                    right = middle - 1;
                }
            }
            return -1;
        }


        public bool Search2DArray(int target, int[,] array)
        {
            // identify the row which may contain the target
            //Console.WriteLine(array.GetLength(0));      // 1st Dim of array - rows
            //Console.WriteLine(array.GetLength(1));      // 2nd Dim of array - columns

            var rows = array.GetLength(0);
            var cols = array.GetLength(1);

            // if a row found
            // find the element with in it

            var topRowFirst = array[0, 0];
            var lastRowLast = array[rows - 1, cols - 1];

            if (target < topRowFirst || target > lastRowLast)
                return false;

            var topRowIndex = 0;
            var bottomRowIndex = rows - 1;

            while (topRowIndex <= bottomRowIndex)
            {
                var midRowIndex = (topRowIndex + bottomRowIndex) / 2;
                if (target < array[midRowIndex, 0])
                {
                    // go up
                    bottomRowIndex = midRowIndex - 1;
                }
                else if (target > array[midRowIndex, cols - 1])
                {
                    // go down
                    topRowIndex = midRowIndex + 1;
                }
                else
                {
                    // its maybe within this row
                    // perform binary search on this row
                    var left = 0;
                    var right = cols - 1;
                    while (left <= right)
                    {
                        var mid = (left + right) / 2;
                        if (target < array[midRowIndex, mid])
                        {
                            // go left
                            right = mid - 1;
                        }
                        else if (target > array[midRowIndex, mid])
                        {
                            // go right
                            left = mid + 1;
                        }
                        else
                        {
                            // found 
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}