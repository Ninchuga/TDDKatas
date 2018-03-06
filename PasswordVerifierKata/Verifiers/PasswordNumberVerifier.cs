using System.Linq;
using PasswordVerifierKata.Extensions;

namespace PasswordVerifierKata.Verifiers
{
	public class PasswordNumberVerifier : IAmPasswordVerifier
	{
		private const string PasswordWithoutNumberExceptionMessage = "Password must have at least one number.";

		public void Verify(Password password)
			=> password.Verify(p => !p.ToString().Any(char.IsNumber), PasswordWithoutNumberExceptionMessage);
		
	}
}