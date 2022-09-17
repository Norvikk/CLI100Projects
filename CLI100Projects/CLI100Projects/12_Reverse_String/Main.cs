namespace Projects
{
    internal static class ReverseString
    {
        public static string Reverse(string _string) => new string(_string.Reverse().ToArray());
    }
}
