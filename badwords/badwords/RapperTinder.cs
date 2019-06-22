using System.Collections.Generic;
using System.Windows.Forms;

namespace badwords
{
    public class RapperTinder : Form
    {
        private List<Rapper> rappers;
        private Song knowSong;
            public RapperTinder(List<Rapper> rappers, Song knowSong)
        {
            this.rappers = rappers;
            this.knowSong = knowSong;

            var songSwearStats = new SwearStats();
            songSwearStats.AddSwearsFrom(knowSong);

            Program._Form.clearList();
            foreach (var rapper in rappers)
            { 
                var score = rapper.FindCommonSwaerScore(songSwearStats);
                //Console.WriteLine(rapper.name + ": " + score + " points.");
                Program._Form.updateList(rapper.name + ": " + score + " points.");
                //MessageBox.Show(rapper.name + ": " + score + " points.");
            }
        }
    }
}
