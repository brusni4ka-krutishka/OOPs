namespace Lab9
{
    static public class ChangeString
    {
        public static string MyToLower(string str)
        {
            str = str.ToLower();
            return str;
        }

        public static string AddLetter(string str, char letter)
        {
            str += letter;
            return str;
        }

        public static string AddPoint(string str)
        {
            str += ".";
            return str;
        }

        public static string MyToUpper(string str)
        {
            str = str.ToUpper();
            return str;
        }

        public static string Ii(string str)
        {
            str = str.Replace("i", "I");
            return str;
        }

    }
}
