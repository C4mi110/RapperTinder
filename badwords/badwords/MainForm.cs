using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace badwords
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            string artist = Textbox_artist.Text;
            string song = Textbox_song.Text;

            var XxxtentacionStats = new Rapper("Xxxtentacion");
            XxxtentacionStats.Addsong("Changes");
            XxxtentacionStats.Addsong("Sad!");
            XxxtentacionStats.Addsong("Jocelyn Flores");
            XxxtentacionStats.Addsong("Moonlight");
            XxxtentacionStats.Addsong("Fuck Love");

            var PostMaloneStats = new Rapper("Post Malone");
            PostMaloneStats.Addsong("Rockstar");
            PostMaloneStats.Addsong("Psycho");
            PostMaloneStats.Addsong("Sunflower");
            PostMaloneStats.Addsong("Wow.");
            PostMaloneStats.Addsong("Better Now");

            var LilUziVertStats = new Rapper("Lil Uzi Vert");
            LilUziVertStats.Addsong("Bad And Boujee");
            LilUziVertStats.Addsong("XO TOUR Llif3");
            LilUziVertStats.Addsong("Watch");
            LilUziVertStats.Addsong("The Way Life Goes");
            LilUziVertStats.Addsong("New Patek");

            var LilBabyStats = new Rapper("Lil Baby");
            LilBabyStats.Addsong("Drip too hard");
            LilBabyStats.Addsong("Yes Indeed");
            LilBabyStats.Addsong("Pure Cocaine");
            LilBabyStats.Addsong("Close Friends");
            LilBabyStats.Addsong("Never Recover");

            var _21SavageStats = new Rapper("21 Savage");
            _21SavageStats.Addsong("Bank Account");
            _21SavageStats.Addsong("A Lot");
            _21SavageStats.Addsong("Nothin New");
            _21SavageStats.Addsong("No Heart");
            _21SavageStats.Addsong("All The Smoke");

            var LilSkiesStats = new Rapper("Lil Skies");
            LilSkiesStats.Addsong("I");
            LilSkiesStats.Addsong("Lust");
            LilSkiesStats.Addsong("Red Roses");
            LilSkiesStats.Addsong("Creeping");
            LilSkiesStats.Addsong("Nowdays");

            var LogicStats = new Rapper("Logic");
            LogicStats.Addsong("Homicide");
            LogicStats.Addsong("1-800-273-8255");
            LogicStats.Addsong("Everyday");
            LogicStats.Addsong("Keanu Reeves");
            LogicStats.Addsong("Icy");

            var JuiceWRLDStats = new Rapper("Juice WRLD");
            JuiceWRLDStats.Addsong("Lucid Dreams");
            JuiceWRLDStats.Addsong("Robbery");
            JuiceWRLDStats.Addsong("Armed and Dangerous");
            JuiceWRLDStats.Addsong("All girls are the same");
            JuiceWRLDStats.Addsong("Feeling");

            var rappers = new List<Rapper>();
            rappers.Add(XxxtentacionStats);
            rappers.Add(PostMaloneStats);
            rappers.Add(LilSkiesStats);
            rappers.Add(LilUziVertStats);
            rappers.Add(LogicStats);
            rappers.Add(LilBabyStats);
            rappers.Add(_21SavageStats);
            rappers.Add(JuiceWRLDStats);

            var UnknowSong = new Song(artist, song);
            var tinder = new RapperTinder(rappers, UnknowSong);
        }
    }
}
