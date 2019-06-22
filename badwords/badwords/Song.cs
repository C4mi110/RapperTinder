using Newtonsoft.Json;
using SearchingCurses;
using System.Text.RegularExpressions;

namespace badwords
{
    public class Song {
        public string tiitle;
        public string artist;
        public string lyrics;
        public Song(string band, string song)
        {
            if (band != "")
            {
                //var browser = new WebClient();
                var url = "https://api.lyrics.ovh/v1/" + band + "/" + song;
                //var json = browser.DownloadString(url);

                var json = WebCache.GetOrDownload(url);

                var lyricsData = JsonConvert.DeserializeObject<LyricsAnswer>(json);

                tiitle = song;
                artist = band;
                lyrics = lyricsData.lyrics;
            }
            else {
                lyrics = song;
            }

        }

        public int CountOccurrences(string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Match(lyrics, pattern, RegexOptions.IgnoreCase).Length;  
        }
    }
}
