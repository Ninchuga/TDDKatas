using System;

namespace PasswordVerifierKata
{
	public class Password
	{
		private const string PasswordNullArgumentExceptionMessage = "Password must be provided.";
		private const string PasswordWithoutLowerCaseExceptionMessage = "Password must have at least one lower case letter.";
		private readonly string _password;

		private Password(string password)
		{
			_password = password;
		}

		public static Password From(string password)
		{
			if (string.IsNullOrWhiteSpace(password))
				throw new ArgumentException(PasswordNullArgumentExceptionMessage);
			if (password.Equals(password.ToUpper()))
				throw new ArgumentException(PasswordWithoutLowerCaseExceptionMessage);

			return new Password(password);
		}

		public override bool Equals(object obj)
		{
			var password = obj as Password;
			return password != null && this._password.Equals(password._password);
		}

		public override int GetHashCode()
		{
			return _password.GetHashCode();
		}

		public static implicit operator string(Password password) => password?.ToString();

		public override string ToString() => _password;

		public Password ToLower => From(_password.ToLower());

		public int Length => _password.Length;
	}
}