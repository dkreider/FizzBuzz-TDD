using Xunit;

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(19)]
        public void Buzzer_When_Default_Returns_Input(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.Equal(input.ToString(), output);
        }

        [Fact]
        public void Buzzer_When_3_Returns_Fizz()
        {
            // -- Arrange
            int input = 3;

            // -- Act
            string output = FizzBuzzer.GetValue(input);

            // -- Assert
            Assert.Equal("Fizz", output);
        }
        [Fact]
        public void Buzzer_When_5_Returns_Buzz()
        {
            // -- Arrange
            int input = 5;

            // -- Act
            string output = FizzBuzzer.GetValue(input);

            // -- Assert
            Assert.Equal("Buzz", output);
        }        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        public void Buzzer_When_Dividable_By_3_Returns_Fizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.Equal("Fizz", output);
        }     
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void Buzzer_When_Dividable_By_5_Returns_Buzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.Equal("Buzz", output);
        }
        [Theory]
        [InlineData(15)]
        public void Buzzer_When_Dividable_By_3_And_5(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.Equal("FizzBuzz", output.ToString());
        }
    }
}
