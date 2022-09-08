namespace Projects
{
    internal static class DeEnCrypter
    {
        // More complex example of Character Obfuscation: https://github.com/Norvikk/Deenk
        // A simple Encryption Algorithm that can be reverse engineered  
        public static void Encrypt(string _payload, string _password)
        {
            

            if (_password.Length <= 8 || string.IsNullOrEmpty(_payload)) { throw new Exception("Password or Text are of subject to invalid sizing"); }

        
            List<byte> _byteList = _payload.Select(x => Convert.ToByte(x)).ToList();
            List<int> _intList = _password.Select(x => Convert.ToInt32(x.ToString())).ToList();

            foreach (byte b in _byteList) { Console.WriteLine(b); }
            foreach (int i in _intList) { Console.WriteLine(i); }

        }

        

    }
}
