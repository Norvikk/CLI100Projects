namespace Projects
{
    internal static class PasswordGenerator
    {
        private static int RandomSecureInt(int min, int max) =>
            System.Security.Cryptography.RandomNumberGenerator.GetInt32(min, max);

        public static string GetSecureRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[RandomSecureInt(0, s.Length)])
                    .ToArray()
            );
        }

        public static string GetSecureRandomSymbol(int length)
        {
            const string chars = "!#$%&()*.,-/:;><=?@[]^_'{]|~ ";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[RandomSecureInt(0, s.Length + 1)])
                    .ToArray()
            );
        }

        public static string Generate(int digits = 4, int characters = 5, int symbol = 1)
        {
            string _password = "";
            _password += DigitSection(4);
            _password += CharacterSection(5);
            _password += SymbolSection(1);

            return _password;
        }

        private static string DigitSection(int lenght)
        {
            string _result = "";
            for (int i = 0; i < lenght; i++)
            {
                _result += RandomSecureInt(0, 10).ToString();
            }
            return _result;
        }

        private static string CharacterSection(int lenght) => GetSecureRandomString(lenght);

        private static string SymbolSection(int lenght) => GetSecureRandomSymbol(lenght);
    }
}
