namespace TheTyrants.Models.Patterns.StudentPatterns
{
    abstract class StudentDecorator : Student
    {
        public abstract void ChangeState(string state);
    }
}
