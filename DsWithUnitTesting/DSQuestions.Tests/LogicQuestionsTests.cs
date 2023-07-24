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
    }
}