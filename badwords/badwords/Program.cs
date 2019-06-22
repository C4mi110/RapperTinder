using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
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
        private Label label_artist;
        private Label label_song;
        public RadioButton radioButton_know;
        public RadioButton radioButton_unknow;
        public TextBox textBox_lyrics;
        private Label label_lyrics;
        private TextBox textBox_artist;

        public Program()
        {
            InitializeComponent();
            _Form = this;
        }
        public static Program _Form;
        public void clearList()
        {
            listBox_output.Items.Clear();
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.textBox_artist = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_song = new System.Windows.Forms.TextBox();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.label_artist = new System.Windows.Forms.Label();
            this.label_song = new System.Windows.Forms.Label();
            this.radioButton_know = new System.Windows.Forms.RadioButton();
            this.radioButton_unknow = new System.Windows.Forms.RadioButton();
            this.textBox_lyrics = new System.Windows.Forms.TextBox();
            this.label_lyrics = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_artist
            // 
            this.textBox_artist.Location = new System.Drawing.Point(12, 51);
            this.textBox_artist.Name = "textBox_artist";
            this.textBox_artist.Size = new System.Drawing.Size(260, 20);
            this.textBox_artist.TabIndex = 3;
            this.textBox_artist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(85, 116);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(117, 23);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Show similar rappers";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_song
            // 
            this.textBox_song.Location = new System.Drawing.Point(12, 90);
            this.textBox_song.Name = "textBox_song";
            this.textBox_song.Size = new System.Drawing.Size(260, 20);
            this.textBox_song.TabIndex = 4;
            this.textBox_song.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox_output
            // 
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(12, 145);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(260, 147);
            this.listBox_output.TabIndex = 9;
            // 
            // label_artist
            // 
            this.label_artist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_artist.AutoSize = true;
            this.label_artist.Location = new System.Drawing.Point(122, 35);
            this.label_artist.Name = "label_artist";
            this.label_artist.Size = new System.Drawing.Size(42, 13);
            this.label_artist.TabIndex = 4;
            this.label_artist.Text = "Rapper";
            // 
            // label_song
            // 
            this.label_song.AutoSize = true;
            this.label_song.Location = new System.Drawing.Point(122, 74);
            this.label_song.Name = "label_song";
            this.label_song.Size = new System.Drawing.Size(32, 13);
            this.label_song.TabIndex = 5;
            this.label_song.Text = "Song";
            // 
            // radioButton_know
            // 
            this.radioButton_know.AutoSize = true;
            this.radioButton_know.Checked = true;
            this.radioButton_know.Location = new System.Drawing.Point(12, 12);
            this.radioButton_know.Name = "radioButton_know";
            this.radioButton_know.Size = new System.Drawing.Size(137, 17);
            this.radioButton_know.TabIndex = 1;
            this.radioButton_know.TabStop = true;
            this.radioButton_know.Text = "I know rapper and song";
            this.radioButton_know.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButton_know.UseVisualStyleBackColor = true;
            this.radioButton_know.CheckedChanged += new System.EventHandler(this.radioButton_know_CheckedChanged);
            // 
            // radioButton_unknow
            // 
            this.radioButton_unknow.AutoSize = true;
            this.radioButton_unknow.Location = new System.Drawing.Point(171, 12);
            this.radioButton_unknow.Name = "radioButton_unknow";
            this.radioButton_unknow.Size = new System.Drawing.Size(101, 17);
            this.radioButton_unknow.TabIndex = 2;
            this.radioButton_unknow.Text = "I know the lyrics";
            this.radioButton_unknow.UseVisualStyleBackColor = true;
            this.radioButton_unknow.CheckedChanged += new System.EventHandler(this.radioButton_unknow_CheckedChanged);
            // 
            // textBox_lyrics
            // 
            this.textBox_lyrics.Location = new System.Drawing.Point(26, 51);
            this.textBox_lyrics.Multiline = true;
            this.textBox_lyrics.Name = "textBox_lyrics";
            this.textBox_lyrics.Size = new System.Drawing.Size(237, 59);
            this.textBox_lyrics.TabIndex = 5;
            this.textBox_lyrics.Visible = false;
            // 
            // label_lyrics
            // 
            this.label_lyrics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_lyrics.AutoSize = true;
            this.label_lyrics.Location = new System.Drawing.Point(130, 35);
            this.label_lyrics.Name = "label_lyrics";
            this.label_lyrics.Size = new System.Drawing.Size(34, 13);
            this.label_lyrics.TabIndex = 9;
            this.label_lyrics.Text = "Lyrics";
            this.label_lyrics.Visible = false;
            // 
            // Program
            // 
            this.AccessibleName = "";
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.label_lyrics);
            this.Controls.Add(this.textBox_lyrics);
            this.Controls.Add(this.radioButton_unknow);
            this.Controls.Add(this.radioButton_know);
            this.Controls.Add(this.label_song);
            this.Controls.Add(this.label_artist);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.textBox_song);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_artist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Program";
            this.Text = "Rapper Tinder";
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

            string lyrics = textBox_lyrics.Text;

            if (radioButton_know.Checked)
            {
                var KnowSong = new Song(artist, song);
                var tinder = new RapperTinder(rappers, KnowSong);
            }
            else if (radioButton_unknow.Checked)
            {
                var unKnowSong = new Song("", lyrics);
                var tinder = new RapperTinder(rappers, unKnowSong);
            }

        }
        
        private void radioButton_know_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_know.Checked)
            {
                textBox_artist.Visible = true;
                textBox_song.Visible = true;
                label_artist.Visible = true;
                label_song.Visible = true;
            }
            else
            {
                textBox_artist.Visible = false;
                textBox_song.Visible = false;
                label_artist.Visible = false;
                label_song.Visible = false;
            }
        }

        private void radioButton_unknow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_unknow.Checked)
            {
                textBox_lyrics.Visible = true;
                label_lyrics.Visible = true;
            }
            else
            {
                textBox_lyrics.Visible = false;
                label_lyrics.Visible = false;
            }
        }
    }
    public class LyricsAnswer {
        public string lyrics;
        public string error;
    }
}
