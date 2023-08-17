namespace DSQuestions.Tests
{
    public class Tests
    {
        private LogicQuestions _logicQuestions = null!;

        [SetUp]
        public void Setup()
        {
            _logicQuestions = new LogicQuestions();
        }

        [Test]
        [TestCase(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 8, new[] { 1, 2, 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 1, new[] { 4, 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4, 1, 2 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 3, new[] { 2, 3, 4, 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 3, 4, 5, 1, 2 })]
        public void RotateArrayByK_WhenCalled_Rotates(int[] array, int k, int[] expectedRotation)
        {
            // arrange
            // done in setup

            // act
            var actualRotation = _logicQuestions.RotateArrayByK(array, k);

            // assert
            Assert.That(actualRotation, Is.EquivalentTo(expectedRotation));
        }

        [Test]
        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        public void Reverse_WhenCalled_ReversedArray(int[] array, int[] reversed)
        {
            // arrange
            // done in setup

            // act
            var actualReversed = _logicQuestions.Reverse(array);

            // assert
            Assert.That(actualReversed, Is.EquivalentTo(reversed));
        }

        [Test]
        [TestCase(new int[0], 1, new int[0])]
        [TestCase(new[] { 1 }, 1, new int[0])]
        [TestCase(new[] { 2, 7 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 2, 1, 7 }, 9, new[] { 0, 2 })]
        [TestCase(new[] { 2, 7, 3, -1, 4 }, 2, new[] { 2, 3 })]
        [TestCase(new[] { 2, 7, 3, -1, 4 }, 100, new int[0])]
        public void TwoSum_WhenCalled_ReturnsArrayWithIndexing(int[] data, int sum, int[] indexes)
        {
            // arrange
            // done in setup

            // act
            var indexesFound = _logicQuestions.TwoSum(data, sum);

            // assert
            Assert.That(indexesFound, Is.EquivalentTo(indexes));
        }

        [Test]
        [TestCase("", "a", false)]
        [TestCase(null, "a", false)]
        [TestCase("a", "", false)]
        [TestCase("a", null, false)]
        [TestCase("", "", false)]
        [TestCase(null, null, false)]

        [TestCase("aba", "pqr", false)]
        [TestCase("abacus", "rirfgs", true)]
        [TestCase("ababr", "eoeoo", false)]
        [TestCase("ababr", "pqrqo", false)]
        [TestCase("badc", "baba", false)]
        public void IsIsomorphic_WhenCalled_ReturnsTrueIfIsomorphic(string strOne, string strTwo, bool isIsomorphic)
        {
            // arrange
            // done in setup

            // act
            var actual = _logicQuestions.IsIsomorphic(strOne, strTwo);

            // assert
            Assert.That(actual, Is.EqualTo(isIsomorphic));
        }

        [Test]
        public void GetFibonacci_WhenCalled_ReturnsFib()
        {
            // arrange
            var fibonacciSequence = new[]
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711,
                28657, 46368, 75025, 121393, 196418, 317811, 514229
            };

            // act & assert
            for (var i = 0; i < fibonacciSequence.Length; i++)
            {
                Assert.That(_logicQuestions.GetFibonacci(i), Is.EqualTo(fibonacciSequence[i]));
            }
        }

        [Test]
        public void GetFibonacciWithMemoization_WhenCalled_ReturnsFib()
        {
            // arrange
            var fibonacciSequence = new[]
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711,
                28657, 46368, 75025, 121393, 196418, 317811, 514229
            };

            // act & assert
            for (var i = 0; i < fibonacciSequence.Length; i++)
            {
                Assert.That(_logicQuestions.GetFibonacciWithMemoization(i), Is.EqualTo(fibonacciSequence[i]));
            }
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase(" ", null)]
        [TestCase("Aabc1Acbd", 1)]
        [TestCase("aabAA33b", null)]
        [TestCase("aBA", 0)]
        public void GetFirstNonRepeatingIndex_WhenCalled_GetFirstNonRepeatingIndex(string input, int? expectedRepeatingIndex)
        {
            // arrange
            // done in setup

            // act
            var actual = _logicQuestions.GetFirstNonRepeatingIndex(input);

            // assert
            Assert.That(actual, Is.EqualTo(expectedRepeatingIndex));
        }

        [Test]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase(" ", false)]
        [TestCase("abcba", true)]
        [TestCase("abccba", true)]
        [TestCase("malayalam", true)]
        [TestCase("malayalaM", false)]
        [TestCase("b", true)]
        [TestCase("abca", false)]
        [TestCase("aA", false)]
        public void IsPalindrome_WhenCalled_ReturnTrueIfPalindrome(string str, bool expected)
        {
            // arrange
            // done in setup

            // act
            var actual = _logicQuestions.IsPalindrome(str);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11, -1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, -1)]
        [TestCase(new[] { 1, 2 }, 1, 0)]
        [TestCase(new[] { 1, 2 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 4)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 6, 5)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9)]
        public void BinarySearch_WhenCalled_ReturnsIndexIfFoundElseNegOne(int[] sortedArray, int value, int index)
        {
            // arrange
            // done in setup

            // act
            var actual = _logicQuestions.BinarySearch(sortedArray, value);

            // assert
            Assert.That(actual, Is.EqualTo(index));
        }


        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11, -1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, -1)]
        [TestCase(new[] { 1, 2 }, 1, 0)]
        [TestCase(new[] { 1, 2 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 4)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 6, 5)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9)]
        public void RecursiveBinarySearch_WhenCalled_ReturnsIndexIfFoundElseNegOne(int[] sortedArray, int value, int index)
        {
            // arrange
            var left = 0;
            var right = sortedArray.Length - 1;

            // act
            var actual = _logicQuestions.RecursiveBinarySearch(sortedArray, value, left, right);

            // assert
            Assert.That(actual, Is.EqualTo(index));
        }

        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11, -1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, -1)]
        [TestCase(new[] { 1, 2 }, 1, 0)]
        [TestCase(new[] { 1, 2 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 4)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 6, 5)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new[] { 3, 4, 5, 1, 2 }, 3, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 4, 3)]
        [TestCase(new[] { 3, 4, 5, 6, 1, 2 }, 4, 1)]
        public void SortedRotatedSearch_WhenCalled_ReturnsIndexIfFoundElseNegOne(int[] sortedRotatedArray, int value,
            int index)
        {
            // arrange
            // done in setup

            // act
            var actual = _logicQuestions.SortedRotatedSearch(sortedRotatedArray, value);

            // assert
            Assert.That(actual, Is.EqualTo(index));
        }

        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11, -1)]
        //[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, -1)]
        //[TestCase(new[] { 1, 2 }, 1, 0)]
        //[TestCase(new[] { 1, 2 }, 2, 1)]
        //[TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        //[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 2)]
        //[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 4)]
        //[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 6, 5)]
        //[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 0)]
        //[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9)]
        //[TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        //[TestCase(new[] { 3, 4, 5, 1, 2 }, 3, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 4, 3)]
        //[TestCase(new[] { 3, 4, 5, 6, 1, 2 }, 4, 1)]
        public void RecursiveSortedRotatedSearch_WhenCalled_ReturnsIndexIfFoundElseNegOne(int[] sortedRotatedArray, int value,
            int index)
        {
            // arrange
            // done in setup

            // act
            var actual = _logicQuestions.RecursiveSortedRotatedSearch(sortedRotatedArray, value, 0, sortedRotatedArray.Length - 1);

            // assert
            Assert.That(actual, Is.EqualTo(index));
        }
    }
}