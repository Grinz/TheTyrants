namespace TheTyrants.Models.Teachers
{
    public class Eisenmann : Teacher
    {
        public string LaughAtStudents()
        {
            this.manliness += 2;
            return "Eisenmann se moque toujours autant des élèves qu'il voit.";
        }

        public string Threat()
        {
            this.LoosePatience(2);
            return "Eisenmann commence à hausser le ton et menace les élèves qui ne se mettent pas au travail !";
        }
    }
}
