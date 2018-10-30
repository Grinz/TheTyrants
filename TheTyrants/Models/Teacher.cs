using System.Collections.Generic;
using TheTyrants.Models.Paterns;

namespace TheTyrants.Models
{
    public class Teacher
    {
        public string Id { get; set; }
        public int Patience  { get; set; }

        public int manliness { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Discipline { get; set; }
        public int Life { get; set; }
        public School School { get; set; }
        public List<Memento> Mementos { get; set; } = new List<Memento>();




        public string LooseLife(int value)
        {
            this.Life -= value;
            return $"{this.FirstName} {this.Name} perd "+value+"pts de vie.";

        }

        public string LoosePatience()
        {

            string txt = "";

            Patience -= 1;

            if (Patience == 0)
            {
                txt = "la patience de " + this.Name + " est à bout, il perd 2 pts de vie...";
                Life -= 2;
                Patience = 6;
            }
            else
            {
                txt = $"{this.FirstName} {this.Name} perd patience. (Patience: {this.Patience}).";
            }
            return txt;

        }

        public string LoosePatience(int value)
        {
            string txt = "";

            Patience -= value;

            if (Patience == 0)
            {
                txt = "la patience de " + this.Name + " est à bout, il perd 2 pts de vie...";
                Life -= 2;
                Patience = 6;
            }
            else
            {
                txt = $"{this.FirstName} {this.Name} perd patience. (Patience: {this.Patience}).";
            }
            return txt;

        }

        public void PatienceReedeem()
        {
            Patience += 1;
        }


        public string LooseManliness(int value)
        {
            string txt = "";

            manliness -= value;

            if (manliness == 0)
            {
                txt = "la virilité de " + this.Name + " est touchée, il perd 2 pts de vie...";
                Life -= 2;
                manliness = 4;
            }
            else
            {
                txt = $"{this.FirstName} {this.Name} perd de sa virilité. (virilité: {this.manliness}).";
            }
            return txt;

        }

        public void RedeemManliness()
        {
            manliness += 1;
        }

        public string Teach()
        {
            return $"{this.FirstName} {this.Name} est en train d'enseigner son cours de {this.Discipline}.";
        }

        public string BecomeAngry()
        {
            this.Patience -= 2;
            string txt = "";
            if (Patience == 0)
            {
                txt = "la patience de " + this.Name + " est à bout, il perd 2 pts de vie...";
                Life -= 2;
                Patience = 6;
            }
            else
            {
                txt = $"{this.FirstName} {this.Name} commence à s'énerver !";
            }
            return txt;
        }

        public void CreateMemento()
        {
            Mementos.Add(new Memento { Id = this.Id, Life = this.Life });
        }

        public void SetMemento(string id, int life)
        {
            Mementos.Find(s => s.Id.Equals(id)).Life = life;
        }
    }
}
