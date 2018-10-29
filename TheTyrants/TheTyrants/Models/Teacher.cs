using System.Collections.Generic;
using TheTyrants.Models.Paterns;

namespace TheTyrants.Models
{
    public class Teacher
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Discipline { get; set; }
        public int Life { get; set; }
        public School School { get; set; }
        public List<Memento> Mementos { get; set; } = new List<Memento>();

        public string Teach()
        {
            return $"{this.FirstName} {this.Name} est en train d'enseigner son cours de {this.Discipline}.";
        }

        public string BecomeAngry()
        {
            return $"{this.FirstName} {this.Name} commence à s'énerver !";
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
