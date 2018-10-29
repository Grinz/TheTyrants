namespace TheTyrants.Models.Paterns
{
    public class Memento
    {
        public string Id { get; set; }
        public int Life { get; set; }

        public void UpdateLife(int life)
        {
            Life = life;
        }
    }
}
