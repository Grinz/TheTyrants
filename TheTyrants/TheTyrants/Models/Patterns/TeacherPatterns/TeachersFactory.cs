namespace TheTyrants.Models.Patterns.TeacherPatterns
{
    public class TeachersFactory
    {
        public static Teacher CreateTeacher(string teacherType)
        {
            switch (teacherType)
            {
                case "kind":
                    return new KindTeacher();
                case "evil":
                    return new EvilTeacher();
                default:
                    return null;
            }
        }
    }
}
