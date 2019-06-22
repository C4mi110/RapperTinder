using Newtonsoft.Json;
using SearchingCurses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace badwords
{
    public partial class Program : Form
    {
        private Button button_confirm;
        private TextBox textBox_song;
        public ListBox listBox_output;
        private Label label1;
        private Label label2;
        private TextBox textBox_artist;

        public Program()
        {
            InitializeComponent();
            _Form = this;
        }
        public static Program _Form;
        public void updateList(string result)
        {
            listBox_output.Items.Add(result);
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            this.textBox_artist = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_song = new System.Windows.Forms.TextBox();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_artist
            // 
            this.textBox_artist.Location = new System.Drawing.Point(12, 25);
            this.textBox_artist.Name = "textBox_artist";
            this.textBox_artist.Size = new System.Drawing.Size(260, 20);
            this.textBox_artist.TabIndex = 0;
            this.textBox_artist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(92, 90);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(95, 23);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "Znajdź rappera!";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_song
            // 
            this.textBox_song.Location = new System.Drawing.Point(12, 64);
            this.textBox_song.Name = "textBox_song";
            this.textBox_song.Size = new System.Drawing.Size(260, 20);
            this.textBox_song.TabIndex = 2;
            this.textBox_song.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox_output
            // 
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(12, 128);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(260, 160);
            this.listBox_output.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rapper";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Song";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.textBox_song);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_artist);
            this.Name = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            var MacMillerStats = new Rapper("Mac Miller");
            MacMillerStats.Addsong("Self Care");
            MacMillerStats.Addsong("Ladders");
            MacMillerStats.Addsong("Weekend");
            MacMillerStats.Addsong("Hurt Feelings");
            MacMillerStats.Addsong("Donald Trump");

            var XxxtentacionStats = new Rapper("Xxxtentacion");
            XxxtentacionStats.Addsong("Sad!");
            XxxtentacionStats.Addsong("Jocelyn Flores");
            XxxtentacionStats.Addsong("Moonlight");
            XxxtentacionStats.Addsong("Fuck Love");
            XxxtentacionStats.Addsong("Changes");

            var LilUziVertStats = new Rapper("Lil Uzi Vert");
            LilUziVertStats.Addsong("Sanguine Paradise");
            LilUziVertStats.Addsong("XO Tour Llif3");
            LilUziVertStats.Addsong("That's A Rack");
            LilUziVertStats.Addsong("The way life goes");
            LilUziVertStats.Addsong("New Patek");

            var LogicStats = new Rapper("Logic");
            LogicStats.Addsong("Homicide");
            LogicStats.Addsong("1-800-273-8255");
            LogicStats.Addsong("Everyday");
            LogicStats.Addsong("Keanu Reeves");
            LogicStats.Addsong("Icy");

            var LilSkiesStats = new Rapper("Lil Skies");
            LilSkiesStats.Addsong("I");
            LilSkiesStats.Addsong("Lust");
            LilSkiesStats.Addsong("Red Roses");
            LilSkiesStats.Addsong("Creeping");
            LilSkiesStats.Addsong("Nowadays");

            var JuiceWRLDStats = new Rapper("Juice WRLD");
            JuiceWRLDStats.Addsong("Lucid Dreams");
            JuiceWRLDStats.Addsong("Robbery");
            JuiceWRLDStats.Addsong("Armed And Dangerous");
            JuiceWRLDStats.Addsong("All girls are the same");
            JuiceWRLDStats.Addsong("Feeling");

            var _21SavageStats = new Rapper("21 Savage");
            _21SavageStats.Addsong("a lot");
            _21SavageStats.Addsong("Bank Account");
            _21SavageStats.Addsong("monster");
            _21SavageStats.Addsong("can't leave without it");
            _21SavageStats.Addsong("X");

            var PostMaloneStats = new Rapper("Post Malone");
            PostMaloneStats.Addsong("Sunflowe");
            PostMaloneStats.Addsong("wow.");
            PostMaloneStats.Addsong("rockstar");
            PostMaloneStats.Addsong("Better now");
            PostMaloneStats.Addsong("Psycho");

            var LilWayneStats = new Rapper("Lil Wayne");
            LilWayneStats.Addsong("Sucker for Pain");
            LilWayneStats.Addsong("Uproar");
            LilWayneStats.Addsong("Scared of the Dark");
            LilWayneStats.Addsong("A milli");
            LilWayneStats.Addsong("Mona Lisa");

            var TravisScottStats = new Rapper("Travis Scott");
            TravisScottStats.Addsong("The London");
            TravisScottStats.Addsong("SICKO MODE");
            TravisScottStats.Addsong("goosebumps");
            TravisScottStats.Addsong("Power is Power");
            TravisScottStats.Addsong("YOSEMITE");

            var rappers = new List<Rapper>();
            rappers.Add(MacMillerStats);
            rappers.Add(XxxtentacionStats);
            rappers.Add(LilUziVertStats);
            rappers.Add(LogicStats);
            rappers.Add(LilSkiesStats);
            rappers.Add(JuiceWRLDStats);
            rappers.Add(_21SavageStats);
            rappers.Add(PostMaloneStats);
            rappers.Add(LilWayneStats);
            rappers.Add(TravisScottStats);

            string artist = textBox_artist.Text;
            string song = textBox_song.Text;

            var KnowSong = new Song(artist, song);
            var tinder = new RapperTinder(rappers, KnowSong);
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    public class RapperTinder : Form
    {
        private List<Rapper> rappers;
        private Song unknowSong;
            public RapperTinder(List<Rapper> rappers, Song unknowSong)
        {
            this.rappers = rappers;
            this.unknowSong = unknowSong;

            var songSwearStats = new SwearStats();
            songSwearStats.AddSwearsFrom(unknowSong);

            foreach (var rapper in rappers)
            { 
                var score = rapper.FindCommonSwaerScore(songSwearStats);
                //Console.WriteLine(rapper.name + ": " + score + " points.");
                Program._Form.updateList(rapper.name + ": " + score + " points.");
                //MessageBox.Show(rapper.name + ": " + score + " points.");
            }
        }
    }

    public class Rapper : SwearStats
    {
        public string name;
        public Rapper(string name)
        {
            this.name = name;
        }
        public void Addsong(string tittle)
        {
            var song = new Song(band: name, song: tittle);
            AddSwearsFrom(song);
        }
    }

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

    public class Song {
        public string tiitle;
        public string artist;
        public string lyrics;
        public Song(string band, string song)
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

        public int CountOccurrences(string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Match(lyrics, pattern, RegexOptions.IgnoreCase).Length;  
        }
    }
    public class LyricsAnswer {
        public string lyrics;
        public string error;
    }
}
