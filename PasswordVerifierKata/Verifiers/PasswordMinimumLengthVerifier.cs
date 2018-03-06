using PasswordVerifierKata.Extensions;

namespace PasswordVerifierKata.Verifiers
{
	public class PasswordMinimumLengthVerifier : IAmPasswordVerifier
	{
		private const int MinimumPasswordLength = 9;
		private static readonly string MinimumPasswordLengthExceptionMessage = $"Passsword must be at least {MinimumPasswordLength} characters long.";

		public void Verify(Password password) 
			=> password.Verify(p => p.Length < MinimumPasswordLength, MinimumPasswordLengthExceptionMessage);

	}
}