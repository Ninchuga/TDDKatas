using PasswordVerifierKata.Extensions;

namespace PasswordVerifierKata.Verifiers
{
	public class PasswordUpperCaseVerifier : IAmPasswordVerifier
	{
		private const string PasswordWithoutUpperCaseExceptionMessage = "Password must have at least one upper case letter.";

		public void Verify(Password password)
			=> password.Verify(p => p.Equals(password.ToLower), PasswordWithoutUpperCaseExceptionMessage);
		
	}
}