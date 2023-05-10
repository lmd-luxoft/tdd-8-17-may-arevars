using TDDKataCalk;

namespace TDD1
{
    public class UnitTest1
    {
        ///Create a simple String calculator with a method int Add(string numbers)The method can take 0, 1 or 2 numbers, and will return their sum(for an empty string it will return 0) for example “” or “1” or “1, 2”
        ///Start with the simplest test case of an empty string and move to 1 and 2 numbers
        ///Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
        ///Remember to refactor after each passing test
        [Fact]
        public void EmptyStringCheckingTest()
        {
            //Arrange
            string a = "";
            int expected = 0;

            var calculator = new Calc();

            //Act
            var actual = calculator.Add(a);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringWithoutAnyNumbersTest()
        {
            //Arrange
            string a = "asdfasd^$%^%$^%";
            int expected = -1;

            var calculator = new Calc();

            //Act
            var actual = calculator.Add(a);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringWithNumbersButWithoutComaTest()
        {
            //Arrange
            string a = "asdfasd^$%^%$^%223-=0";
            int expected = -1;

            var calculator = new Calc();

            //Act
            var actual = calculator.Add(a);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringWithMoreThan2NumbersInItTest()
        {
            //Arrange
            string a = "1,2,3";
            int expected = -1;

            var calculator = new Calc();

            //Act
            var actual = calculator.Add(a);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringWithCorrectNumbersButWithOtherCharactersTest()
        {
            //Arrange
            string a = "qwee1,2,3rtyrty";
            int expected = -1;

            var calculator = new Calc();

            //Act
            var actual = calculator.Add(a);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}