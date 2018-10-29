namespace TheTyrants.Models.Patterns.StudentPatterns
{
    public class StudentsFactory
    {
        public static Student CreateStudent(string studentType)
        {
            switch (studentType)
            {
                case "kind":
                    return new KindStudent();
                case "evil":
                    return new EvilStudent();
                default:
                    return null;
            }
        }
    }
}
