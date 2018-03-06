namespace PasswordVerifierKata.Verifiers
{
	public interface IAmPasswordVerifier
	{
		void Verify(Password password);
	}
}