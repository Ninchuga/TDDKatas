using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsKata
{
	public class NumberConverter
	{
		private readonly Dictionary<int, string> _romanArabicNumerals = RomanNumerals.Get();

		public string Convert(int givenNumber)
		{
			var result = new StringBuilder();
			var arrayOfNumberDigits = givenNumber.ToString().ToCharArray();
			if (givenNumber == 0 || givenNumber > 3000 || arrayOfNumberDigits.Length > 4)
				return "Provided number is not valid";

			for (int i = 0; i < arrayOfNumberDigits.Length; i++)
			{
				int digit = arrayOfNumberDigits[i] - '0'; // this is used to remove UTF16 value of the character
				int numberOfZeros = arrayOfNumberDigits.Length - (i + 1);

				int roundNumber = GetRoundNumber(digit, numberOfZeros);

				if (_romanArabicNumerals.ContainsKey(roundNumber))
					result.Append(_romanArabicNumerals[roundNumber]);
			}

			return result.Length == 0 ? "Provided number is not valid" : result.ToString();
		}

		private static int GetRoundNumber(int digit, int numberOfDecades)
		{
			if (digit == 0 || numberOfDecades == 0) return digit;

			return CreateRoundNumber(numberOfDecades, digit);
		}

		private static int CreateRoundNumber(int numberOfDecades, int digit)
		{
			var roundNumber = 0;
			for (int j = 0; j < numberOfDecades; j++)
			{
				var decades = new[] { 10, 100, 1000 };
				roundNumber = digit * decades[j];
			}
			return roundNumber;
		}
	}
}
