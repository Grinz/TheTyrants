namespace TheTyrants.Models.Patterns
{
    public class Mediator
    {
        public string ArriveInClass(string firstName, string name)
        {
            return $"{firstName} {name} vient d'arriver en classe.";
        }

        public string ExitClass(string firstName, string name)
        {
            return $"{firstName} {name} vient de quiter la classe.";
        }

        public string TakeABreak(string firstName, string name)
        {
            return $"{firstName} {name} prend une pause.";
        }

        public string Speak(string firstName, string name, string sentence)
        {
            return $"{firstName} {name} dit : {sentence}.";
        }
    }
}
