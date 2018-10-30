namespace TheTyrants.Models.Teachers
{
    public class Thery : Teacher
    {
        public string Cry()
        {
            this.LooseManliness(1);
            return "Thery commence à pleurer dans son coin à force d'être maltraité par l'ensemble de la classe...";
        }

        public string SpeackAlone()
        {
            this.LooseManliness(1);
            return "Thery, comme tous les jours, fait son cours seul, face au tableau.";
        }

        public string Ragequit()
        {
            this.LooseLife(2);
            return "N'étant écouté de personne, Thery quitte la classe sans rien dire. Personne ne le remarque.";
        }
    }
}
