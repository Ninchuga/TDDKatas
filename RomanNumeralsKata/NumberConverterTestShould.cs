using FluentAssertions;
using Xunit;

namespace RomanNumeralsKata
{
    public class NumberConverterTestShould
    {
	    [Fact]
	    public void ReturnErrorMessageIfZeroIsPassedAsANumber()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(0);

		    result.Should().Be("Provided number is not valid");
		}

        [Theory]
		[InlineData(1)]
		[InlineData(5)]
		[InlineData(9)]
        public void ConvertSingleDigitNumberIntoRomanNumeral(int number)
        {
	        var converter = new NumberConverter();

	        var result = converter.Convert(number);

	        result.Should().NotBe(string.Empty);
        }

	    [Fact]
	    public void ConvertSingleDigitNumberlIntoValidRomanNumeral()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(7);

		    result.Should().Be("VII");
		}

	    [Fact]
	    public void ConvertDoubleDigitNumberIntoRomanNumeral()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(38);

		    result.Should().Be("XXXVIII");
		}

	    [Fact]
	    public void ConvertTripleDigitNumberIntoRomanNumerals()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(357);

		    result.Should().Be("CCCLVII");
		}

	    [Fact]
	    public void ConvertFourDigitNumberIntoRomanNumerals()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(2018);

		    result.Should().Be("MMXVIII");
		}

	    [Fact]
	    public void ReturnErrorMessageIfNumberIsMoreThenThreeThousand()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(6000);

		    result.Should().Be("Provided number is not valid");
		}

	    [Fact]
	    public void ReturnErrorMessageIfNumberHasMoreThenFourDigits()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(656544);

		    result.Should().Be("Provided number is not valid");
		}

	    [Fact]
	    public void ConvertToRomanNumeralsIfProvidedNumberStartsWithZero()
	    {
			var converter = new NumberConverter();

		    var result = converter.Convert(00123);

		    result.Should().Be("CXXIII");
		}
	}
}
