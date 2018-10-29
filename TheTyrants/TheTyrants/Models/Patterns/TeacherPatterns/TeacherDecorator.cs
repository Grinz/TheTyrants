namespace TheTyrants.Models.Patterns.TeacherPatterns
{
    abstract class TeacherDecorator : Teacher
    {
        public abstract void ChangeState(string state);
    }
}
