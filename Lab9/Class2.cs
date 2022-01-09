namespace Lab9
{
    static public class ChangeString
    {
        public static string MyToLower(string str) => str.ToLower();
       

        public static string AddLetter(string str, char letter) => str += letter;

        public static string AddPoint(string str) =>str += ".";


        public static string MyToUpper(string str)=> str.ToUpper();


        public static string Ii(string str)=>str.Replace("i", "I");


    }
}
