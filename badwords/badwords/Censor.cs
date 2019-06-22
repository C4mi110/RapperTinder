using System.IO;
using System.Text.RegularExpressions;

namespace badwords
{
    public class Censor
    {
        protected string[] badwords;
        public Censor()
        {
            var profanitiesfile = File.ReadAllText("profanities.txt");
            profanitiesfile = profanitiesfile.Replace("*", "");
            profanitiesfile = profanitiesfile.Replace("(", "");
            profanitiesfile = profanitiesfile.Replace(")", "");
            profanitiesfile = profanitiesfile.Replace("\"", "");
            profanitiesfile = profanitiesfile.Replace(";", "");
            profanitiesfile = profanitiesfile.Replace("'", "");

            badwords = profanitiesfile.Split(',');

            foreach (var word in badwords)
            {
                //Console.WriteLine(word);
            }
   
        }

        public string Fix(string tekst)
        {
            foreach (var word in badwords)
            {
                tekst = ReplaceBadWords(tekst, word);
            }
            return tekst;
        }

        private static string ReplaceBadWords(string tekst, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(tekst, pattern, "*** ", RegexOptions.IgnoreCase);
        }
    }
}
