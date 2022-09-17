namespace Projects
{
    internal static class CollatzConjecture
    {
        public static void GenerateOutputFor(int length)
        {
            while (length != 1)
            {
                if (length % 2 == 0) { length /= 2; } // check if even
                else { length = length * 3 + 1; } // is not even

                Console.Write(length + " ");
            }
        }
    }
       
}
