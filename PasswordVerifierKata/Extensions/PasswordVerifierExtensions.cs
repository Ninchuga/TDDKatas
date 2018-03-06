using System;

namespace PasswordVerifierKata.Extensions
{
	public static class PasswordVerifierExtensions
	{
		public static void Verify(this Password password, Func<Password, bool> predicate, string errorMessage)
		{
			if(predicate(password))
				throw new ArgumentException(errorMessage);
		}
	}
}