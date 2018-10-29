namespace TheTyrants.Models.Patterns.TeacherPatterns
{
    class KindTeacher : TeacherDecorator
    {
        public override void ChangeState(string state)
        {
            if (state.ToLower().Equals("worse"))
            {

            }
        }

        private void updateState()
        {

        }
    }
}
