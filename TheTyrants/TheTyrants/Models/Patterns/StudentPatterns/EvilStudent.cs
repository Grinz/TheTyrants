namespace TheTyrants.Models.Patterns.StudentPatterns
{
    class EvilStudent : StudentDecorator
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
