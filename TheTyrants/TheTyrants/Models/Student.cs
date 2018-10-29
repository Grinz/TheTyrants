using System.Collections.Generic;
using TheTyrants.Models.Paterns;

namespace TheTyrants.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public int Life { get; set; }
        public int Hostility { get; set; }
        public List<Course> PastCourses { get; set; }
        public List<Memento> Mementos { get; set; } = new List<Memento>();

        public string AnswerToTeacher()
        {
            return "Oui monsieur !";
        }

        public string Eat()
        {
            return $"{this.FirstName} {this.Name} est en train de manger une pomme.";
        }

        public string Play()
        {
            return $"{this.FirstName} {this.Name} est en train de jouer à un jeu sur son PC.";
        }

        public string ThrowSomething()
        {
            return $"{this.FirstName} {this.Name} jette un stylo sur le professeur !";
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
