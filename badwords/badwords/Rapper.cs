namespace badwords
{
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
}
