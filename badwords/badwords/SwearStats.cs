using System;
using System.Collections.Generic;

namespace badwords
{
    public class SwearStats : Censor
    {
        Dictionary<string, int> AllSwears = new Dictionary<string, int>(); 
        public SwearStats()
        {

        }

        public void AddSwearsFrom(Song song)
        {
            foreach (var badword in badwords) {
                var occurences = song.CountOccurrences(badword);
                if (occurences > 0)
                {
                    if (!AllSwears.ContainsKey(badword))
                    AllSwears.Add(badword, 0);
                AllSwears[badword] = occurences;
                }
            }      
        }

        public void ShowSummary()
        {
            foreach (var word in AllSwears)
                Console.WriteLine(word.Key + " " + word.Value);
        }

        public int FindCommonSwaerScore(SwearStats anotherStats)
        {
            int score = 0;
            foreach (var myWord in AllSwears)
            { 
                if (anotherStats.AllSwears.ContainsKey(myWord.Key))
                    score++;
            }
            return score;                     

        }
    }
}
