using DeEnCrypter.Sequences;
using DeEnCrypter.AntiSequences;

namespace Projects
{
    internal static class DeEnCrypter
    {
        // More complex example of Character Obfuscation: https://github.com/Norvikk/Deenk
        // A simple Encryption Algorithm that can be reverse engineered
        public static void Encrypt(string _payload, string _password)
        {
            if (_password.Length <= 8 || string.IsNullOrEmpty(_payload))
            {
                throw new Exception("Password or Text are of subject to invalid sizing");
            }

            CommonRedistributables.payload = _payload;
            CommonRedistributables.password = _password;

            Sequences.S0();
        }

        public static class CommonRedistributables
        {
            public static string password = "";
            public static string payload = "";
        }

        public static void Decrypt(string _payload, string _password)
        {
            if (_password.Length <= 8 || string.IsNullOrEmpty(_payload))
            {
                throw new Exception("Password or Text are of subject to invalid sizing");
            }

            CommonRedistributables.payload = _payload;
            CommonRedistributables.password = _password;

            AntiSequences.AS0();
        }
    }
}
