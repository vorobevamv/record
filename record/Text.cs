namespace Namespace
{
    public class Text
    {
        public static string CreateText(int number)
        {
            if (number % 7 == 0)
            {
                return "abracadabra";
            }
            return null;
        }

        public static void Print(string text)
        {
            if (text is null)
            {
                Console.WriteLine("no magic");
            }
            else if (text is not null)
            {
                Console.WriteLine(text);
            }
        }
    }
}
