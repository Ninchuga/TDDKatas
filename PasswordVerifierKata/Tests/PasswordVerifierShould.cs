using System;
using FluentAssertions;
using PasswordVerifierKata.Verifiers;
using Xunit;

namespace PasswordVerifierKata.Tests
{
	public class PasswordVerifierShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void ThrowExceptionIfPasswordIsNullOrEmptyString(string password)
		{
			var verifier = new PasswordVerifier();

			Action result = () => verifier.Verify(Password.From(password));

			result.Should().Throw<ArgumentException>().WithMessage("Password must be provided.");
		}

		[Theory]
		[InlineData("pass")]
		[InlineData("pass1")]
		public void ThrowExceptionIfPasswordIsLessThanRequired(string password)
		{
			var verifier = new PasswordMinimumLengthVerifier();

			Action result = () => verifier.Verify(Password.From(password));

			result.Should().Throw<ArgumentException>().WithMessage("Passsword must be at least 9 characters long.");
		}

		[Theory]
		[InlineData("passwordtest")]
		[InlineData("passwordtest1")]
		public void ThrowExceptionIfPasswordDoesntHaveUpperCase(string password)
		{
			var verifier = new PasswordUpperCaseVerifier();

			Action result = () => verifier.Verify(Password.From(password));

			result.Should().Throw<ArgumentException>().WithMessage("Password must have at least one upper case letter.");
		}

		[Theory]
		[InlineData("PASSWORDTEST")]
		[InlineData("PASSWORDTEST123")]
		public void ThrowExceptionIfPasswordDoesntHaveLowerCase(string password)
		{
			var verifier = new PasswordVerifier();

			Action result = () => verifier.Verify(Password.From(password));

			result.Should().Throw<ArgumentException>().WithMessage("Password must have at least one lower case letter.");
		}

		[Theory]
		[InlineData("Passwordtest")]
		public void ThrowExceptionIfPasswordDoesntHaveNumber(string password)
		{
			var verifier = new PasswordNumberVerifier();

			Action result = () => verifier.Verify(Password.From(password));

			result.Should().Throw<ArgumentException>().WithMessage("Password must have at least one number.");
		}

		[Theory]
		[InlineData("Passwordtest")]
		[InlineData("Passwordtest1")]
		[InlineData("passwordtest1")]
		public void NotThrowExceptionIfPasswordConditionsAreSatisfied(string password)
		{
			var verifier = new PasswordVerifier();

			Action result = () => verifier.Verify(Password.From(password));

			result.Should().NotThrow<ArgumentException>();
		}

		[Theory]
		[InlineData("pass")]
		[InlineData(null)]
		[InlineData("PASSWORD123")]
		public void ThrowExceptionIfPasswordConditionsAreNotSatisfied(string password)
		{
			var verifier = new PasswordVerifier();

			Action result = () => verifier.Verify(Password.From(password));

			result.Should().Throw<ArgumentException>();
		}
	}
}
