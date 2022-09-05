namespace Projects
{
    internal static class NameGenerator
    {
        public static string GenerateName(bool isMale = false, bool isFemale = false, bool wantsLastName = true)
        {
            Random rand = new();

            string _firstName = " ";
            string _lastName = " ";


            if (isMale) { _firstName = Names.MaleNames[rand.Next(0, Names.MaleNames.Length)].ToLower(); }
            else if (isFemale) { _firstName = Names.FemaleNames[rand.Next(0, Names.FemaleNames.Length)].ToLower(); }
            else { _firstName = Names.MixedNames[rand.Next(0, Names.MixedNames.Length)].ToLower();}

            if (wantsLastName) { _lastName = Names.LastNames[rand.Next(0, Names.LastNames.Length)].ToLower(); }


            char[] _carrier1 = _firstName.ToCharArray();
            _carrier1[0] = char.ToUpper(_carrier1[0]);

            char[] _carrier2 = _lastName.ToCharArray();
            _carrier2[0] = char.ToUpper(_carrier2[0]);

            return $"{new string(_carrier1)} {new string(_carrier2)}";
        }
    }
}