using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
	public class FizzBuzzTestShould
	{
		[Theory]
		[InlineData(3)]
		[InlineData(6)]
		[InlineData(9)]
		public void PrintFizzForMultiplesOfThree(int number)
		{
			var program = new FizzBuzzProgram();

			var result = program.FizzBuzz(number);

			result.Should().Be("Fizz");
		}

		[Theory]
		[InlineData(5)]
		[InlineData(10)]
		[InlineData(20)]
		public void PrintBuzzForMultiplesOfFive(int number)
		{
			var program = new FizzBuzzProgram();

			var result = program.FizzBuzz(number);

			result.Should().Be("Buzz");
		}

		[Theory]
		[InlineData(15)]
		[InlineData(30)]
		[InlineData(45)]
		public void PrintFizzBuzzForMultiplesOfThreeAndFive(int number)
		{
			var program = new FizzBuzzProgram();

			var result = program.FizzBuzz(number);

			result.Should().Be("FizzBuzz");
		}

		[Theory]
		[InlineData(1)]
		[InlineData(44)]
		[InlineData(79)]
		public void PrintNumberThatIsNotMultipleWithThreeAndFive(int number)
		{
			var program = new FizzBuzzProgram();

			var result = program.FizzBuzz(number);

			result.Should().Be(number.ToString());
		}

	}
}