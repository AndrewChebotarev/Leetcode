namespace Reverse_String_Prefix
{
    public class Reverse_String_Prefix
    {
        public Reverse_String_Prefix(string s, int k)
        {
            char[] sArray = s.ToCharArray();
            Array.Reverse(sArray, 0, k);

            Console.WriteLine(new string(sArray));
        }
    }
}
