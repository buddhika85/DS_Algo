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
    }
}