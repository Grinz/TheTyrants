using System.Collections.Generic;

namespace TheTyrants.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
