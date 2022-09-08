namespace Projects
{
    internal static class DeEnCrypter
    {
        // More complex example of Character Obfuscation: https://github.com/Norvikk/Deenk
        public static void Encrypt(string _payload, int _password)
        {
            // A simple Encryption Algorithm that can be reverse engineered  

            if (_password.ToString().Length <= 8 || string.IsNullOrEmpty(_payload)) { throw new Exception("Password or Text are of subject to invalid sizing"); }
           

            int __possibleShuffles = 0;
            List<string> __shufflePayload = new();

           
            char[] _text = _payload.ToCharArray();

            

            foreach (char c in _text)
            {
                byte _byteText = Convert.ToByte(c);

                __possibleShuffles++;
                __shufflePayload.Add(Convert.ToInt32(c).ToString());
            }

            foreach (string key in __shufflePayload)
            {
                Console.WriteLine(key);
            }

            GenerateKeys(_password);
        } 

        public static int[] GenerateKeys(int password)
        {
            char[] _sequences = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            List<byte> _spunSequence = new();

            foreach (char key in _sequences)
            {
                _spunSequence.Add(Convert.ToByte(key));
                Console.WriteLine(Convert.ToByte(key));
            }

            //do some fuckery with the password and the byte number and call it a day


            return null;
        }


       
    }
}
