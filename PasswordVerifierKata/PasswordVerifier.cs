using System;
using System.Collections.Generic;
using PasswordVerifierKata.Verifiers;

namespace PasswordVerifierKata
{
	public class PasswordVerifier : IAmPasswordVerifier
	{
		private readonly List<IAmPasswordVerifier> _passwordVerifiers = new List<IAmPasswordVerifier>
		{
			new PasswordMinimumLengthVerifier(),
			new PasswordUpperCaseVerifier(),
			new PasswordNumberVerifier()
		};

		public void Verify(Password password)
		{
			var exceptions = new List<Exception>();

			_passwordVerifiers.ForEach(passwordVerifier =>
			{
				try
				{
					passwordVerifier.Verify(password);
				}
				catch (ArgumentException ex)
				{
					exceptions.Add(ex);
				}
			});

			if (exceptions.Count > 1)
				throw new ArgumentException(string.Join("; ", exceptions));
		}
	}
}